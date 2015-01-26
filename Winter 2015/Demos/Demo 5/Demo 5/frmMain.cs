using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (lbStooges.SelectedIndex == -1) //No selection
                MessageBox.Show("Please select your favorite stooge.");
            else
                MessageBox.Show("Your favorite stooge is apparently " +
                    lbStooges.SelectedItem);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            nudNumber.Value = 1;
            nudNumber.Minimum = 0;
            lbStooges.Items.Add("Curly");
            lbStooges.Items.Add("Moe");
            lbStooges.Items.Add("Larry");
            lbStooges.Items.Add("Curly Joe");
            lbStooges.Items.Add("Shemp");
            nudNumber.Maximum = lbStooges.Items.Count - 1;
            lbStooges.SelectedIndex = 1;
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            lbStooges.SelectedIndex = (int)nudNumber.Value;
        }

        private void lbStooges_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudNumber.Value = lbStooges.SelectedIndex;
        }
    }
}
