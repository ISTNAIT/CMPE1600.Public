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

namespace LE_2
{
    public struct SRange
    {
        public int lower;
        public int upper;
        public SRange(int lower, int upper)
        {
            this.lower = lower;
            this.upper = upper;
        }
    }

    public partial class frmMain : Form
    {
        public List<Thread> threads = new List<Thread>(4);
        public delegate int delIntSRange(SRange range);
        public delegate void delvoidInt(int value);
        public int count = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int lower = 1000000000;
            int upper = 1100000000;
            int range = upper - lower;
            int inc = range / 4;
            int current = lower;
            Thread t = null;
            SRange s;

            tbOutput.Text = "Calculating...";

            for (int i = 0; i < 3; ++i)
            {
                s = new SRange(current, current + inc);
                current = current + inc + 1;
                t = new Thread(new ParameterizedThreadStart(ThreadWork));
                t.Start(s);
                t.IsBackground = true;
                threads.Add(t);
            }

            s = new SRange(current, upper);
            t = new Thread(new ParameterizedThreadStart(ThreadWork));
            t.Start(s);
            t.IsBackground = true;
            threads.Add(t);

            timer.Enabled = true;
        }

        public void UpdateOutput(int value)
        {
            count += value;
            //tbOutput.Text = "4:" + count.ToString();
        }

        //returns true sum digits is same for number and sqrt
        bool TestValue (int val)
        {
            return (SumDigits(val) == SumDigits((int)Math.Sqrt(val)));
        }

        int CountTrue(SRange range)
        {
            int total = 0;
            for (int i = range.lower; i <= range.upper; ++i)
                if (TestValue(i)) total++;
            return total;
        }

        void ThreadWork(object Range)
        {
            int count = 0;
            if (Range is SRange)
            {
                count = CountTrue((SRange)Range);
            }

            if(InvokeRequired)
            {
                try
                {
                    Invoke(new delvoidInt(UpdateOutput), count);

                }
                catch
                {
                    MessageBox.Show("Aiiiieeeee!!!");
                }
            }
        }


        int SumDigits(int val)
        {
            int sum = 0;
            while(val > 0)
            {
                //Add the rightmost digit
                sum += (val % 10);
                //Right shift (base 10)
                val /= 10;
            }
            return sum;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool active = false;
            foreach (Thread t in threads)
                if (t.ThreadState != ThreadState.Stopped)
                    active = true;
            if (!active)
                tbOutput.Text = "4:" + count;
        }
    }
}
