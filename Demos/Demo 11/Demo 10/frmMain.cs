using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Demo_10
{
    public partial class frmMain : Form
    {
        public delegate void delVoidVoid();
        public delegate void delVoidObject(object obj);
        private const int PoolSize = 10;

        public frmMain()
        {
            InitializeComponent();
        }

        public struct Limits
        {
            public Limits(int min, int max )
                { minimum = min; maximum = max; }
            public int minimum;
            public int maximum;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch (btnAction.Text)
            {
                case "Start":
                    btnAction.Text = "Working...";
                    lbPrimes.Items.Clear();
                    nudCount.Value = 0;
                    StartThreads();
                    break;

                case "Working": case "Sorting": default:
                    MessageBox.Show("I'm busy, dammit", "Working", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void StartThreads()
        {
            //How many threads do I need?
            int itemCount = ((int)(nudMax.Value - nudMin.Value)) + 1;
            int threadCount = itemCount / (int)nudInterval.Value + 1;
            pbProgress.Maximum = threadCount-1; //Counting from 0 ...
            pbProgress.Value = 0; //We're about to start ...
            

            //Split up my ranges
            int increment = (int)nudInterval.Value;
            int maximum = (int)nudMax.Value;
            
            int current = (int)nudMin.Value;
            int next = current + increment;

            while (current <= maximum)
            {
                if (next > maximum) next = maximum;
                //Just throw it into the threadpool, see if it can swim...
                ThreadPool.QueueUserWorkItem(new WaitCallback(FindPrimes), new Limits(current, next));
                
                current = next + 1;
                next = current + increment;
            }
        }

        private void IncrementCount()
        {
            //lock (nudCount) //Not necessary with delegates, which are atomic
            {
                nudCount.Value++;
            }
        }

        private void IncrementProgress()
        {
            //Designed as a callback for the threads when they are done.
            if (pbProgress.Value < pbProgress.Maximum)
                pbProgress.Value++;
            if (pbProgress.Value >= pbProgress.Maximum)
            {
                btnAction.Text = "Start";
                pbProgress.Value = 0;
                SortListBox();
            }
        }

        private void SortListBox()
        {
            //Stupid listbox sorts alphabetically.
            //There are more elegant ways to do this, but brute force is easy to follow.
            btnAction.Text = "Sorting...";
            pbProgress.Maximum = lbPrimes.Items.Count*2;
            pbProgress.Value = 0;
            List<int> values = new List<int>(lbPrimes.Items.Count);
            foreach (object o in lbPrimes.Items)
            {
                values.Add((int)o);
                pbProgress.Value++;
            }
            values.Sort(); lbPrimes.Items.Clear();
            foreach (int i in values)
            {
                lbPrimes.Items.Add(i);
                pbProgress.Value++;
            }
            btnAction.Text = "Start";
           
        }

        private void AddPrime(object val)
        {
            lbPrimes.Items.Add(val);
        }

        private void FindPrimes(object limits)
        {
            if (!(limits is Limits)) return;
            Limits l = (Limits)limits;

            for(int val = l.minimum; val <= l.maximum; ++val)
                if (primep(val))
                //It was prime!
                {
                    if (InvokeRequired)
                    {
                        try
                        {
                            Invoke(new delVoidVoid(IncrementCount));
                            Invoke(new delVoidObject(AddPrime),val);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("We've made a terrible mistake: " + ex.Message, "Invoke Exception", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            //All done this thread
            if (InvokeRequired)
            {
                try { Invoke (new delVoidVoid(IncrementProgress));}

                catch (Exception ex)
                    { MessageBox.Show("We've made a terrible mistake: " + ex.Message, "Invoke Exception", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
        }

        bool primep(int val)
        {
            //return true iff val is prime
            if (val <= 1) return false;
            for (int i = 2; i <= val / 2; ++i)
                if (val % i == 0)
                    return false;
            return true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

    }
}
