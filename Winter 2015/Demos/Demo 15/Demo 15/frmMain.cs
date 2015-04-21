using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_15
{
    public partial class frmMain : Form
    {

        List<SItem> items = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            items = new List<SItem>();
            items.Add(new SItem("Larry", "the Rat", 15, 1));
            items.Add(new SItem("Barry", "the Manilow", 65, 2));
            items.Add(new SItem("Mary", "the Shepherdess", 13, 1));

            lvData.Columns.Add("First Name");
            lvData.Columns.Add("Last Name");
            lvData.Columns.Add("Age");

            lvData.LargeImageList = ilImages;
            lvData.SmallImageList = ilImages;
            int j = 0;
            foreach (SItem i in items)
            {
                ListViewItem lvi = lvData.Items.Add(i.ToLVI());
                lvi.ImageIndex = j++;
            }
            lvData.Sort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (lvData.View)
            {
                case View.Details: lvData.View = View.LargeIcon; break;
                case View.LargeIcon: lvData.View = View.List; break;
                case View.List: lvData.View = View.SmallIcon; break;
                case View.SmallIcon: lvData.View = View.Details; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvData.CheckedItems)
            {
                lvi.Remove();
            }
        }


    }
}
