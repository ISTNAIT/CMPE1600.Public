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
        public List<Thread> threadList = null;

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
                    btnAction.Text = "Stop";
                    lbPrimes.Items.Clear();
                    nudCount.Value = 0;
                    StartThreads();
                    while (!ThreadDoneP()) ;
                    btnAction.Text = "Start";
                        break;
                default:
                    StopThreads();
                    btnAction.Text = "Start";
                    break;
            }
        }

        private void StartThreads()
        {
            //How many threads do I need?
            int itemCount = ((int)(nudMax.Value - nudMin.Value)) + 1;
            int threadCount = itemCount / (int)nudInterval.Value + 1;
            threadList = new List<Thread>(threadCount);

            //Split up my ranges
            int increment = (int)nudInterval.Value;
            int maximum = (int)nudMax.Value;
            
            int current = (int)nudMin.Value;
            int next = current + increment;

            while (current <= maximum)
            {
                if (next > maximum) next = maximum;
                //Create some threads
                threadList.Add(new Thread(new ParameterizedThreadStart(FindPrimes)));
                threadList.Last().Start(new Limits(current, next));
                current = next + 1;
                next = current + increment;
            }

        }

        private bool ThreadDoneP()
        {
            if (threadList==null || threadList.Count < 1) return true;
            foreach (Thread t in threadList)
                if (t.ThreadState == ThreadState.Running)
                    return false;
            return true;
        }

        private void StopThreads()
        {
            //But I can't!  They're out of my control!!

        }

        private void IncrementCount()
        {
            //lock (nudCount) //Not necessary with delegates, which are atomic
            {
                nudCount.Value++;
            }
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
    }
}
