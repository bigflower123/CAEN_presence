using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAEN_presence_classe
{
    public partial class FormAlert : Form
    {
        public FormAlert()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            registerForm rf = new registerForm();
            rf.Owner = this;
            rf.StartPosition = FormStartPosition.CenterScreen;
            rf.textBoxID.Text = labelAlertID.Text;
            rf.textBoxID.Enabled = false;
            rf.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
