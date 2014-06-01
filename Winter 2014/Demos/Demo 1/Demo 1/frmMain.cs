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
            System.Diagnostics.Trace.WriteLine("Form Loading.");
            lblStatus.Text = "";
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

            System.Diagnostics.Trace.WriteLine("Form has been shown.");
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = String.Format("Mouse is at {0},{1}", e.X, e.Y);
        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("You double clicked!"));
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(String.Format("You clicked {0}",((MouseEventArgs)e).Button.ToString()));
        }

    }
}
