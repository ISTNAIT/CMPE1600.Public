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
    public enum MovieSelection
    {
        Serenity,
        BluesBrothers,
        BreakfastAtTiffanys
    }

    public partial class frmMovie : Form
    {

        private bool pLikesMovies = false;

        public MovieSelection SelectedMovie
        {
            get
            {
                if (rbBlues.Checked) return MovieSelection.BluesBrothers;
                if (rbTiffanys.Checked) return MovieSelection.BreakfastAtTiffanys;
                return MovieSelection.Serenity;
            }
        }

        public bool LikesMovies
        {
            get {return cbLike.Checked;}
            set { pLikesMovies = value; }
        }

        public frmMovie()
        {
            InitializeComponent();
        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            cbLike.Checked = pLikesMovies;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
