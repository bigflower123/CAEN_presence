namespace CAEN_presence_classe
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.InformationStatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.IPtextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.IDTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Major = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Present_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelShowNumber = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.CheckTotTagsTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerRecord = new System.Windows.Forms.Timer(this.components);
            this.labelLogo = new System.Windows.Forms.Label();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SalleNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.IPtextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "connention";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformationStatusToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 93);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(243, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // InformationStatusToolStripStatusLabel
            // 
            this.InformationStatusToolStripStatusLabel.AccessibleName = "";
            this.InformationStatusToolStripStatusLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationStatusToolStripStatusLabel.Name = "InformationStatusToolStripStatusLabel";
            this.InformationStatusToolStripStatusLabel.Size = new System.Drawing.Size(128, 17);
            this.InformationStatusToolStripStatusLabel.Text = "input TCP/IP address";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(9, 59);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(95, 31);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // IPtextBox1
            // 
            this.IPtextBox1.Location = new System.Drawing.Point(69, 23);
            this.IPtextBox1.Name = "IPtextBox1";
            this.IPtextBox1.Size = new System.Drawing.Size(163, 20);
            this.IPtextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP address";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(137, 59);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(95, 31);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // listViewInventory
            // 
            this.listViewInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDTags,
            this.Prenom,
            this.Nom,
            this.StudentNo,
            this.Major,
            this.Present_Time,
            this.SalleNo});
            this.listViewInventory.GridLines = true;
            this.listViewInventory.Location = new System.Drawing.Point(0, 167);
            this.listViewInventory.MultiSelect = false;
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(957, 313);
            this.listViewInventory.TabIndex = 15;
            this.listViewInventory.UseCompatibleStateImageBehavior = false;
            this.listViewInventory.View = System.Windows.Forms.View.Details;
            // 
            // IDTags
            // 
            this.IDTags.Text = "IDTags";
            this.IDTags.Width = 248;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 120;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 120;
            // 
            // StudentNo
            // 
            this.StudentNo.Text = "studentNo";
            this.StudentNo.Width = 120;
            // 
            // Major
            // 
            this.Major.Text = "Major";
            this.Major.Width = 100;
            // 
            // Present_Time
            // 
            this.Present_Time.Text = "PresentTime";
            this.Present_Time.Width = 150;
            // 
            // labelShowNumber
            // 
            this.labelShowNumber.AutoSize = true;
            this.labelShowNumber.Location = new System.Drawing.Point(9, 138);
            this.labelShowNumber.Name = "labelShowNumber";
            this.labelShowNumber.Size = new System.Drawing.Size(68, 13);
            this.labelShowNumber.TabIndex = 16;
            this.labelShowNumber.Text = "total number:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(83, 138);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(13, 13);
            this.labelNumber.TabIndex = 17;
            this.labelNumber.Text = "0";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(813, 113);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(110, 38);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "start record";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(813, 35);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 38);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "register";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // CheckTotTagsTimer
            // 
            this.CheckTotTagsTimer.Interval = 250;
            this.CheckTotTagsTimer.Tick += new System.EventHandler(this.CheckTotTagsTimer_Tick);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStrip2.Location = new System.Drawing.Point(0, 458);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(957, 22);
            this.statusStrip2.TabIndex = 24;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.AccessibleName = "";
            this.toolStripStatusLabelMain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabelMain.Text = "Not recording now";
            // 
            // timerRecord
            // 
            this.timerRecord.Interval = 250;
            this.timerRecord.Tick += new System.EventHandler(this.timerRecord_Tick);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Location = new System.Drawing.Point(837, 463);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(88, 13);
            this.labelLogo.TabIndex = 25;
            this.labelLogo.Text = "DI3 projet de SE ";
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Checked = true;
            this.checkBox0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox0.Location = new System.Drawing.Point(229, 137);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(58, 17);
            this.checkBox0.TabIndex = 26;
            this.checkBox0.Text = "Salle 0";
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(401, 137);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "Salle2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(315, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Salle 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(487, 137);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 17);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "Salle 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // SalleNo
            // 
            this.SalleNo.Text = "SalleNo";
            this.SalleNo.Width = 100;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 480);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox0);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelShowNumber);
            this.Controls.Add(this.listViewInventory);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.Text = "Who is here";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox IPtextBox1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.ListView listViewInventory;
        private System.Windows.Forms.ColumnHeader IDTags;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader StudentNo;
        private System.Windows.Forms.ColumnHeader Major;
        private System.Windows.Forms.ColumnHeader Present_Time;
        private System.Windows.Forms.Label labelShowNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        protected internal System.Windows.Forms.ToolStripStatusLabel InformationStatusToolStripStatusLabel;
        private System.Windows.Forms.Timer CheckTotTagsTimer;
        private System.Windows.Forms.StatusStrip statusStrip2;
        protected internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.Timer timerRecord;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ColumnHeader SalleNo;
    }
}

