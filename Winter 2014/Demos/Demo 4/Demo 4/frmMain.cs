using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbStooges.SelectedIndex = 0;
            tmrEvents.Enabled = true;

        }

        private void tbEventSecs_Scroll(object sender, EventArgs e)
        {
            tmrEvents.Interval = tbEventSecs.Value * 1000;
        }

        private void tmrEvents_Tick(object sender, EventArgs e)
        {
            if (lbStooges.SelectedIndex == lbStooges.Items.Count - 1)
                lbStooges.SelectedIndex = 0;
            else
                lbStooges.SelectedIndex = lbStooges.SelectedIndex + 1;
        }
    }
}
