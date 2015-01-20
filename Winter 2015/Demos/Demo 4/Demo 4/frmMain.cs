using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            rbMangos.Checked = true;
            rbApples.Enabled = false; //Disable the apples button
            cbEnableApples.Checked = false;
            timer.Enabled = true;
            timerEnd.Enabled = true;
        }

        private void rbApples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbApples.Checked)
                Console.WriteLine("Apples enabled.");
            else
                Console.WriteLine("Apples disabled");

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbRadio.Controls)
            {
                if (((RadioButton)c).Checked)
                { 
                    string mess = "Your favorite fruit is " + c.Text 
                        + ". Apples is " + (cbEnableApples.Checked?"enabled.":"disabled.");
                    MessageBox.Show(mess);
                }

                timer.Enabled = true;
                timerEnd.Enabled = true;

                //Or, you can:
                //if(rbApples.Checked)
                   // <stuff>
                //else if (rbOranges.Checked)
                  // <other stuff>

            }
        }

        private void cbEnableApples_CheckedChanged(object sender, EventArgs e)
        {
            rbApples.Enabled = cbEnableApples.Checked;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cbEnableApples.Checked = !cbEnableApples.Checked;
        }

        private void timerEnd_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timerEnd.Enabled = false;
        }
    }
}
