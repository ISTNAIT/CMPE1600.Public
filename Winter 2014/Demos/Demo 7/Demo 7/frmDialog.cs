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
    public delegate void undecoratedEvent();
    public delegate void stringEvent(string s);

    public partial class frmDialog : Form
    {
        public undecoratedEvent iAmDying = null;
        public stringEvent heresSomeText = null;

        public frmDialog()
        {
            InitializeComponent();
        }

        public void updateFromText(string s)
        {
            txtFrom.Text = s;
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            iAmDying();
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            heresSomeText(txtTo.Text);
        }
    }
}
