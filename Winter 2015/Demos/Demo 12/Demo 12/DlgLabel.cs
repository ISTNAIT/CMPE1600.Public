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
    public partial class DlgLabel : Form
    {
        public delegate void delVoidVoid();
        public delegate void delVoidString(string value);

        public delVoidVoid UnCheckParent = null;
        public delVoidString ChangeLabel = null;

        public DlgLabel()
        {
            InitializeComponent();
        }

        private void DlgLabel_Load(object sender, EventArgs e)
        {

        }

        public void SetTextbox(string value)
        {
            txtLabel.Text = value;
        }

        private void DlgLabel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                UnCheckParent.Invoke();
                Hide();
            }
        }

        private void txtLabel_TextChanged(object sender, EventArgs e)
        {
            ChangeLabel.Invoke(txtLabel.Text);
        }
    }
}
