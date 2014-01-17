using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_3
{
    public partial class frmMain : Form
    {
        bool Finished = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (Finished)
            {
                MessageBox.Show("You already made your choice!", "Stooges",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            switch (cbConfirm.CheckState)
            {
                case CheckState.Indeterminate:
                    MessageBox.Show("Please Check your Confirmation Option", "Stooges", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case CheckState.Unchecked:
                    FinishUp();
                    break;
                case CheckState.Checked: default:
                    DialogResult dr = MessageBox.Show("Are you sure that is your final decision?", "Stooges", 
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        FinishUp();
                    break;
            }
        }

        private void FinishUp()
        {
            foreach (Control c in gbStooge.Controls)
            {
                ((RadioButton)c).Enabled = false;
                if (((RadioButton)c).Checked)
                    MessageBox.Show(c.Text + " is a good choice.");
                Finished = true;

            }


        }

        private void rbLarry_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarry.Checked)
                MessageBox.Show("Larry?  Seriously?  That's what everyone picks.");

        }

        private void rbMoe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMoe.Checked)
                MessageBox.Show("Moe is pretty good.  Especially the haircut.");
        }

        private void rbCurly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCurly.Checked)
                MessageBox.Show("The savant's choice.  A true genius.");
        }

        private void rbCurlyJoe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCurlyJoe.Checked)
                MessageBox.Show("Philistine!  He is not among the true three!");
        }
    }
}
