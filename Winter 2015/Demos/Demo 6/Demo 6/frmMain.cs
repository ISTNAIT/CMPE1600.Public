using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text + " " +
                numericUpDown1.Value.ToString());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Larry");
            comboBox2.Items.Add("Moe");
            comboBox2.Items.Add("Curly");
            comboBox2.Items.Add("Shemp");
            comboBox2.Text = "Larry";
        }
    }
}
