using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_1
{
    public partial class frmMain : Form
    {
        //We can do custom private member variables
        private int clickCount = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close this application?", "Closing",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("That Tickles! (" + e.X + "," + e.Y + ")");
        }

        private void frmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("There's no help for someone like you.");
        }

        private void frmMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Stop it!  That hurts!");
        }

        private void frmMain_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; //"this" is the object.  In this case the form.
            //Short for.
        }

        private void frmMain_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button_Click(object sender, EventArgs e)
        {
            label.Text = incrementClickCount().ToString();
        }

        
        //We can also creater our own private methods.
        private int incrementClickCount()
        {
            return ++clickCount; //Increment then return the incremented value
        }

        
        private void button_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }


    }
}
