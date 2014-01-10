using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            tbText.Text = "You follow directions well.";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("I am loading.  BOW BEFORE ZOD!");
        }

    }
}
