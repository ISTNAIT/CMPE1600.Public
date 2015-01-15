/************************************************
 * Project:     Demo 3
 * Name:        AJ Armstrong
 * Course:      CMPE1600
 * Date:        15 Jan 2014
 ***********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void tbrValue_Scroll(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            tbxValue.Text = tbrValue.Value.ToString();
        }


        private void tbxValue_Leave(object sender, EventArgs e)
        {
            int value = 0;
            if (int.TryParse(tbxValue.Text, out value))
            {
                if (value > tbrValue.Maximum) value = tbrValue.Maximum;
                if (value < tbrValue.Minimum) value = tbrValue.Minimum;

                tbrValue.Value = value;
            }
           UpdateTextBox();
        }
    }
}
