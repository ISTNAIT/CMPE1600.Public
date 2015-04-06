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

namespace Demo_14
{
    public struct Parameters
    {
        public ulong min;
        public ulong max;

        public Parameters(ulong mini, ulong maxi)
        {
            min = mini;
            max = maxi;
        }
    }

    public partial class frmMain : Form
    {

        public List<Thread> Threads = null;
        public delegate void delUpdateProgress();
        public delegate void delUpdateTriples(string triple);


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        //Add 1% to progress par
        private void UpdateProgress()
        {
            if (pbProgess.Value < 100)
                pbProgess.Value += 1;
            this.Refresh();
        }

        private void UpdateList(string triple)
        {
            lbTriples.Items.Add(triple);
            //this.Refresh();
        }

        private void ThreadWork(object pars)
        {
            try
            {
                if (pars is Parameters)
                {
                    Parameters vals = (Parameters)pars;
                    SearchForTriples(vals.min, vals.max);
                }
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("It's dead, Jim");
            }
        }

        private void SearchForTriples(ulong first, ulong last)
        {
            ulong range = last - first;
            ulong interval = range / 10ul;
            //a is smallest side, b is larger size, c is hypotenuse
            for (ulong c = first; c <= last; ++c) //Possible hypotenuses
            {
                //Update my progress bar
                if (InvokeRequired)
                {
                    Invoke(new delUpdateProgress(UpdateProgress));
                }
                else
                {
                    if (c % interval == 0)
                        UpdateProgress();
                }
                for (ulong b = 1; b <= c; ++b)
                    for (ulong a = 1; a <= b; ++a)
                    {
                        if (a * a + b * b == c * c) //found a triple!
                            if (InvokeRequired)
                            {
                                Invoke(new delUpdateTriples(UpdateList), a + "," + b + "," + c);
                            }
                            else //running in same thread
                            {
                                UpdateList(a + "," + b + "," + c);
                            }
                    }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ulong min = 1ul;
            ulong max = (ulong)nudMax.Value;
            ulong interval = (max - min) / 10ul;
            ulong current = min;
            Thread t = null;
            Threads = new List<Thread>(10);
            for (int i = 0; i < 9; ++i)
            {
                t = new Thread(ThreadWork);
                t.IsBackground = true;
                t.Start(new Parameters(current, current + interval));
                Threads.Add(t);
                current += interval + 1;
            }
            t = new Thread(ThreadWork);
            t.IsBackground = true;
            t.Start(new Parameters(current, max));
            Threads.Add(t);
            SearchForTriples(85ul, (ulong)nudMax.Value);
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            if (Threads != null)
                foreach (Thread t in Threads)
                    if (t.ThreadState != ThreadState.Stopped)
                        btnStart.Enabled = false;
        }
    }
}
