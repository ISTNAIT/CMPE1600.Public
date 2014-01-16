using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            tbText.Text = "";
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Type some text into the form!");
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            if (tbText.Text.Length > 0)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach(string s in tbText.Lines)
                MessageBox.Show(s);
        }
    }
}
