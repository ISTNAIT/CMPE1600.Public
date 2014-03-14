using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_7
{
    public partial class frmMain : Form
    {
        private frmDialog dialog = null;

        public frmMain()
        {
            InitializeComponent();
            btnHide.Enabled = false;
        }

        public void DialogHasSuicided()
        {
            btnHide.Enabled = false;
            btnShow.Enabled = true;
        }

        public void DialogStringUpdate(string s)
        {
            txtFrom.Text = s;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dialog == null)
            {
                dialog = new frmDialog();
                dialog.iAmDying = DialogHasSuicided;
                dialog.heresSomeText = DialogStringUpdate;
            }

            dialog.updateFromText(txtTo.Text);
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = new Point(0, 0);
            dialog.Show();
            btnHide.Enabled = true;
            btnShow.Enabled = false;
            this.Focus();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if(dialog != null) dialog.Hide();
            btnHide.Enabled = false;
            btnShow.Enabled = true;
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            if (dialog != null) dialog.updateFromText(txtTo.Text);
                
        }
    }
}
