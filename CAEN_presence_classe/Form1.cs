using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using com.caen.RFIDLibrary;
using System.Data.OleDb;
using System.IO.Ports;
using System.IO;

namespace CAEN_presence_classe
{
    public partial class mainForm : Form
    {
        
        public CAENRFIDReader MyReader;
        private bool status = false;
        public CAENRFIDLogicalSource[] LogicalSources;
        public List<string> SessionList = new List<string>();   // stock the tags who is detected and not register
        OleDbConnection objConnection;

        public mainForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            this.InformationStatusToolStripStatusLabel.Text = "connecting ...";
            
            try
            {
                Application.DoEvents();
                MyReader = null;
                GC.Collect();
                MyReader = new CAENRFIDReader();
                MyReader.Connect(CAENRFIDPort.CAENRFID_TCP, this.IPtextBox1.Text);
                CAENRFIDReaderInfo info = MyReader.GetReaderInfo();
                MyReader.GetFirmwareRelease();
                MyReader.SetProtocol(CAENRFIDProtocol.CAENRFID_EPC_C1G2);
                this.status = true;
            }
            catch
            {
                this.status = false;
            }

            if (this.status)
            {
                IPtextBox1.Enabled = false;
                buttonConnect.Enabled = false;
                this.InformationStatusToolStripStatusLabel.Text = "connection successful!";
            }
            else
            {
                try
                {
                    MyReader.Disconnect();
                }
                catch
                {
                }
                
                this.InformationStatusToolStripStatusLabel.Text = "CONNECTION REFUSED!!!";
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                checkBox0.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                this.MyReader.Disconnect();
                this.MyReader = null;
                IPtextBox1.Enabled = true;
                buttonConnect.Enabled = true;
                InformationStatusToolStripStatusLabel.Text = "input TCP/IP address";
            }
            catch 
            {
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
      

                if (IPtextBox1.Enabled == false)
                {
                    if (buttonStart.Text == "start record")
                    {

                        if (checkBox0.Checked == false && checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                        {
                            MessageBox.Show("Choose a classroom, please!");
                        }
                        else
                        {
                            string strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;";
                            strConnection += @"Data Source = C:/Users/BAI P/Desktop/CAEN_presence_classe/studentsInfos.accdb ";
                            objConnection = new OleDbConnection(strConnection);

                            objConnection.Open();

                            checkBox0.Enabled = false;
                            checkBox1.Enabled = false;
                            checkBox2.Enabled = false;
                            checkBox3.Enabled = false;
                            CheckTotTagsTimer.Start();
                            timerRecord.Start();
                            listViewInventory.Items.Clear();
                            SessionList.Clear();
                            toolStripStatusLabelMain.Text = "Recording.... now ";
                            buttonStart.Text = "stop record";
                           
                        }
                    }
                    else
                    {
                        objConnection.Close();
                        checkBox0.Enabled = true;
                        checkBox1.Enabled = true;
                        checkBox2.Enabled = true;
                        checkBox3.Enabled = true;
                        CheckTotTagsTimer.Stop();
                        timerRecord.Stop();
                        toolStripStatusLabelMain.Text = "Record stop! ";
                        buttonStart.Text = "start record";
                    }
                }
                else
                {
                    MessageBox.Show("READER has not been connected!");
                }
            
            
          
                
           
        }

        private void scanner_datebase(string id, CAENRFIDTag tag)
        {
            int Flags =0;
            string idTags = "";
            string prenom = "";
            string nom = "";
            string No = "";
            string major = "";
                            
            try
            {
                OleDbCommand sqlcmd = new OleDbCommand(@"SELECT * FROM infos WHERE ID = '" + id + "'", objConnection);
                using (OleDbDataReader reader = sqlcmd.ExecuteReader())
                {
                    if (reader.Read())     // s'il existe dans base de donnee, on l'ajoute dans le ListViewInventory
                    {
                        idTags = reader["ID"].ToString();
                        prenom = reader["prenomStu"].ToString();
                        nom = reader["nomStu"].ToString();
                        No = reader["NumberStu"].ToString();
                        major = reader["MajorStu"].ToString();
                        ListViewItem lvi = new ListViewItem(new string[] { idTags, prenom, nom, No, major, DateTime.Now.ToString(), tag.GetReadPoint() });
                        lvi.Tag = reader;
                        listViewInventory.Items.Add(lvi);
                    }
                    else                  // sinon on demande pour enregistrer par une fenetre FormAlert
                    {
                        if (!SessionList.Contains(id))
                        {
                            SessionList.Add(id);
                        }
                        else
                        {
                            Flags++;
                        }
                        if(Flags == 0)
                        {
                            FormAlert fa = new FormAlert();
                            fa.Owner = this;
                            fa.StartPosition = FormStartPosition.CenterScreen;
                            fa.labelAlertID.Text = id;
                            fa.ShowDialog();
                        }
                    }
                }

            }
            catch
            {
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            registerForm rf = new registerForm();
            rf.Owner = this;
            rf.StartPosition = FormStartPosition.CenterScreen;
            rf.Show();
        }

        private void CheckTotTagsTimer_Tick(object sender, EventArgs e)
        {
            List<string> UniqueID = new List<string>(100);
            foreach (ListViewItem item in this.listViewInventory.Items)
            {
                if (!UniqueID.Contains(item.SubItems[0].Text))
                    UniqueID.Add(item.SubItems[0].Text);
            }
            this.labelNumber.Text = UniqueID.Count.ToString();
        }

        private void timerRecord_Tick(object sender, EventArgs e)
        {
            try
            {
                string EPC;
                int scanStatus = 0;
                CAENRFIDTag[][] MyTags = new CAENRFIDTag[4][];
                if (checkBox0.Checked == true)
                {
                    CAENRFIDLogicalSource MySource = MyReader.GetSource("Source_0");
                    MyTags[0] = MySource.InventoryTag(new byte[] { }, 0, 0, (short)1);  //All tag with rssi
                }
                if (checkBox1.Checked == true)
                {
                    CAENRFIDLogicalSource MySource1 = MyReader.GetSource("Source_1");
                    MyTags[1] = MySource1.InventoryTag(new byte[] { }, 0, 0, (short)1);
                }
                if (checkBox2.Checked == true)
                {
                    CAENRFIDLogicalSource MySource2 = MyReader.GetSource("Source_2");
                    MyTags[2] = MySource2.InventoryTag(new byte[] { }, 0, 0, (short)1);
                }
                if (checkBox3.Checked == true)
                {
                    CAENRFIDLogicalSource MySource3 = MyReader.GetSource("Source_3");
                    MyTags[3] = MySource3.InventoryTag(new byte[] { }, 0, 0, (short)1);
                }
                for (int i = 0; i < 4; i++)
                {
                    if (MyTags[i] != null)
                    {
                        if (MyTags[i].Length > 0)
                        {
                            for (int j = 0; j < MyTags[i].Length; j++)
                            {
                                EPC = BitConverter.ToString(MyTags[i][j].GetId());
                                foreach (ListViewItem item in this.listViewInventory.Items)
                                {
                                    if (item.Text.Equals(EPC))   //  if the tags is read before , we do not search in datebase
                                    {
                                        scanStatus++;
                                    }
                                }

                                if (scanStatus == 0)
                                {
                                    scanner_datebase(EPC,MyTags[i][j]);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                CheckTotTagsTimer.Stop();
                timerRecord.Stop();
                toolStripStatusLabelMain.Text = "Record stop! ";
                buttonStart.Text = "start record";
            }
        }


    }
}
