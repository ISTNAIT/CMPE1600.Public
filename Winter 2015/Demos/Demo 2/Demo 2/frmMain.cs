using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void aboutDemo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is by AJ, who ROCKS!");
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            txtOut.Text = txtIn.Text;
            txtIn.Clear();
            txtIn.Focus();
            btnMain.Enabled = false;
        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {
            btnMain.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnMain.Enabled = false;
        }
    }
}
