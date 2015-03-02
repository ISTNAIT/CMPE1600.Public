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

namespace Demo_8
{
    public partial class frmMain : Form
    {
        private Thread thready = null;
        //define a type for my simple delegate that takes void and returns void
        delegate void delVoidVoid();
        //Delegate that accepts an int and returns an int
        delegate int delIntIntInt(int iOneValue, int iTwoValue);
        //Used with our counting thread
        delegate int delIntInt(int value);

        public frmMain()
        {
            InitializeComponent();

            //This is just some console demo stuff.  
            //Should run as soon as form starts

            //UNICAST
            delVoidVoid bobSaysOne = SayOne;
            bobSaysOne();

            //MULTICAST
            delVoidVoid bobSaysOneTwo = SayOne;
            bobSaysOneTwo += SayTwo;
            bobSaysOneTwo();

            //Parameters!
            delIntIntInt larryScreamsNumbers = SayOnesandTwos;
            int x = larryScreamsNumbers(3,4);
            Console.WriteLine("Larry screamed " +  x + " numbers");
        }

        void SayOne()
        { Console.WriteLine("ONE!"); }

        void SayTwo()
        { Console.WriteLine("TWO!"); }

        int SayOnesandTwos(int ones, int twos)
        {
            for (int i = 0; i < ones; ++i)
                Console.WriteLine("ONE!");
            for (int i = 0; i < twos; ++i)
                Console.WriteLine("TWO!");
            return ones + twos; //number of lines typed.
        }

        private void btnStartThread_Click(object sender, EventArgs e)
        {
            thready = new Thread(new ThreadStart(CountThread));
            thready.IsBackground = true;
            thready.Start();
        }

        private void CountThread()
        {
            for (int i = 0; i < 10; ++i)
            {
                Thread.Sleep(1000);
                //Console is a shared resource, so works fine.
                Console.WriteLine("This is your thread speaking. " +
                    "The current count is " + i);

                //This, however, throws a cross-thead exception.  No playing
                //with form controls from another thread.
                //lblThread.Text = "Thread is counting: " + i;

                //So, let's try it with a delegate and invoke, instead
                if(InvokeRequired) //Am I running in a thread?
                {
                    try
                    {
                        Invoke(new delIntInt(updateLabel),i);
                    }
                    catch (ObjectDisposedException)
                    {
                        System.Diagnostics.Trace.WriteLine("The thread is dead, Jim!" +
                             " I'm a doctor, not a seamstress!");
                    }
                }
            }


        }

        int updateLabel(int value)
        {
            lblThread.Text = "Thread: " + value;
            return value;
        }

        //This is my custom event handler, which I multicast in frmMain.Designer.cs
        private void ShowMessage(object sender, EventArgs e)
            {
                MessageBox.Show("Holy ^&%$snacks!  Multicast!!");
            }
    }
}
