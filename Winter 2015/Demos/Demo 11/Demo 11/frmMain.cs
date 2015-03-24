using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_11
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            dlgName dialog = new dlgName();
            dialog.penguinName = "Type your penguin's name...";
            DialogResult dr = dialog.ShowDialog();

            if(dr==DialogResult.OK)
            {
                lblName.Text = dialog.penguinName;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblName.Text = "";
        }
    }
}
