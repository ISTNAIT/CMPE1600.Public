using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGetMovie_Click(object sender, EventArgs e)
        {
            frmMovie MovieForm = new frmMovie();
            string MovieName = null;
            MovieForm.LikesMovies = false;
            switch(MovieForm.ShowDialog())
            {
                case DialogResult.OK:
                    if (MovieForm.LikesMovies)
                    {
                        switch (MovieForm.SelectedMovie)
                        {
                            case MovieSelection.BreakfastAtTiffanys:
                                MovieName = "Breakfast at Tiffany's"; break;
                            case MovieSelection.Serenity:
                                MovieName = "Serenity"; break;
                            case MovieSelection.BluesBrothers:
                                MovieName = "Blues Brothers"; break;
                            default:
                                MovieName = "What the hell?  How did we get here?"; break;
                        }
                        lblMessage.Text = String.Format("Your favourite movie selection was:{0}", MovieName);
                    }
                    else
                        lblMessage.Text = "Doesn't even like movies.  Sheesh.";
                    break;
                default:
                    lblMessage.Text = "Ummm.  Do you understand how this works?  You need to hit OK.";
                    break;
            }
        }
    }
}
