using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_12
{
    public partial class frmMain : Form
    {
        DlgLabel dlg = null;
        public delegate void delVoidVoid();
        public delegate void delVoidString(string value);

        public frmMain()
        {
            InitializeComponent();
        }

        private void ckDialog_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDialog.Checked)
            {
                if (dlg == null)
                {
                    dlg = new DlgLabel();
                    dlg.ChangeLabel = SetText;
                    dlg.UnCheckParent = UnCheck;
                }
                dlg.Text = tbTitle.Text;
                dlg.SetTextbox("Enter a value for the label...");
                dlg.Show();
            }
            else
            {
                if (dlg != null)
                    dlg.Hide();
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            if (dlg != null)
                 dlg.Text = tbTitle.Text;
        }

        public void UnCheck()
        {
            ckDialog.Checked = false;
        }

        public void SetText(string value)
        {
            lblFromDialog.Text = value;
        }
       
    }
}
