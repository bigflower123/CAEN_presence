using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace CAEN_presence_classe
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text == "" || this.textBoxFirstName.Text == ""|| this.textBoxFamilyName.Text =="" || this.textBoxNo.Text == "" || this.textBoxMajor.Text == "")
            {
                MessageBox.Show(" fill all the blanks,please! ");
            }
            else
            {
                string strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;";
                strConnection += @"Data Source = C:/Users/BAI P/Desktop/CAEN_presence_classe/studentsInfos.accdb ";
                string id = this.textBoxID.Text;
                string prenom = this.textBoxFirstName.Text;
                string nom = this.textBoxFamilyName.Text;
                string No = this.textBoxNo.Text;
                string major = this.textBoxMajor.Text;

                using (OleDbConnection objConnection = new OleDbConnection(strConnection))
                {
                    try
                    {
                        objConnection.Open();
                        OleDbCommand sqlcmd = new OleDbCommand(@"INSERT INTO infos([ID],[prenomStu],[nomStu],[NumberStu],[MajorStu]) VALUES ( '" + id + "','" + prenom + "' ,'" + nom + "','" + No + "','" + major + "')", objConnection);
                        int result = sqlcmd.ExecuteNonQuery();
                        if (result == 1)
                        {
                            mainForm main = new mainForm();
                            main.SessionList.Remove(id);
                            MessageBox.Show("insert successful!");
                        }
                        else
                        {
                            MessageBox.Show("insert failed!");
                        }
                        
                    }
                    catch
                    {
                    }
                    this.Close();
                }
            }
        }
    }
}
