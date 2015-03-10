using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace Demo_9
{
    public delegate void delVoidDecimal(decimal value);
    public delegate void delVoidInt(int value);

    public struct PrimeRange
    {
        public decimal From;
        public decimal To;

        public PrimeRange(decimal from, decimal to)
        {
            From = from;
            To = to;
        }

        public override string ToString()
        {
            return "(" + From + " to " + To + ")";
        }
    }

    public partial class frmMain : Form
    {
        private Thread working;
        private volatile bool stopping;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            switch (btnGo.Text)
            {
                case "Go":
                    btnGo.Text = "Stop";
                    stopping = false;
                    this.Refresh();
                    lbResults.Items.Clear();
                    PrimeRange pr = new PrimeRange(nudFrom.Value, nudTo.Value);
                    working = new Thread(new ParameterizedThreadStart(FindPrimes));
                    working.Start(pr);
                    break;
                case "Stop":
                    btnGo.Text = "Go";
                    stopping = true;
                    break;
            }
        }

        private void FindPrimes(object data)
        {
            if (data is PrimeRange)
            {
                PrimeRange range = (PrimeRange)data;
                decimal width = range.To - range.From;
                decimal currprogress = 0;
                for (decimal value = range.From; value <= range.To; value++)
                {
                    if (stopping) return;
                    //Update progress bar
                    currprogress = value - nudFrom.Value;
                    double progress = (double)currprogress / (double)width;
                    if (InvokeRequired)
                    {
                        try
                        {
                            Invoke(new delVoidInt(UpdateProgress), (int)(progress * 100));
                        }
                        catch (ObjectDisposedException)
                        {
                            System.Diagnostics.Trace.Write("Attempt to access form, when form is dead.  Like, doornail.  Marilyn Monroe. Michael Jackson.");
                        }
                    }

                    if (isPrime(value))
                    {
                        if (InvokeRequired)
                        {
                            try
                            {
                                Invoke(new delVoidDecimal(AddPrime), value);
                            }
                            catch (ObjectDisposedException)
                            {
                                System.Diagnostics.Trace.Write("Attempt to access form, when form is dead.  Like, doornail.  Marilyn Monroe. Michael Jackson.");
                            }
                        }
                    }
                }
            }
        }

        private void UpdateProgress(int value)
        {
            pbProgress.Value = value;
        }

        private void AddPrime(decimal value)
        {
            lbResults.Items.Add(value);
        }


        private bool isPrime(decimal value)
        {
            //Basically iterate from 2 up to see if evenly divisible
            bool primep = true; //Assume prime
            for (decimal i = 2; i <= value / 2; ++i)
            {
                //Stop by request
                if (stopping) return false;
                if (value % i == 0)
                {
                    primep = false;
                    break;
                }
            }
            return primep;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnGo.Text = "Go";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnGo.Text = "Go";
        }
    }
}
