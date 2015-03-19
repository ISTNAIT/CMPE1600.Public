using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_10
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void showMessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am a message!");
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set up file open dialog for the way I want it
            ofdFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdFile.Filter ="All Files (*.*)|*.*|PNG Files (*.png)|*.png|JPG Files (*.jpeg)" +
                "|*.jpeg|GIF Files (*.gif)|*.gif";

            DialogResult dr = ofdFile.ShowDialog();
            if(dr == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(ofdFile.FileName);
                btnStopGo.Enabled = true;
                btnChange.Enabled = true;
            }
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("That tickles!");
        }

        private void btnStopGo_Click(object sender, EventArgs e)
        {
            switch (btnStopGo.Text)
            {
                case "Stop":  //We're stopped, time to go
                    btnStopGo.Text = "Go";
                    tmrToggle.Enabled = false;
                    break;
                case "Go": //We're going, let's stop/
                    btnStopGo.Text = "Stop";
                    tmrToggle.Interval = 1500;
                    tmrToggle.Enabled = true;
                    break;
                default: //What the hell?
                    tmrToggle.Enabled = false;
                    break;
            }
        }

        private void tmrToggle_Tick(object sender, EventArgs e)
        {
            pbImage.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbImage.Refresh();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            btnStopGo.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Bitmap bm = (Bitmap)pbImage.Image;
            for (int x = 0; x< bm.Width; ++x)
                for(int y = 0 ; y < bm.Height; ++y)
                {
                    Color pixel = bm.GetPixel(x, y);
                    int average = pixel.G / 3 + pixel.R / 3 + pixel.B / 3;
                    byte intensity = (byte)average;
                    pixel = Color.FromArgb(intensity, intensity, intensity);
                    bm.SetPixel(x, y, pixel);
                }
            pbImage.Refresh();
        }
    }
}
