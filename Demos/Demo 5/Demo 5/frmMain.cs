using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            wbMain.Url = new Uri("http://www.google.ca");
        }

        private void btnNAIT_Click(object sender, EventArgs e)
        {
            wbMain.Url = new Uri("http://www.nait.ca");
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            wbMain.Url = new Uri("http://news.ycombinator.com");
        }

        private void wbMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //MessageBox.Show(string.Format("You have navigated to: {0}", wbMain.Url));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save me, for god's sake.  There's room for two on that piece of wood!");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can check me!");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show(saveFileDialog1.FileName);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = 
                Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog1.ShowDialog();
        }
    }
}
