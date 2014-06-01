using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Demo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Process myProc = Process.GetCurrentProcess();
            Console.WriteLine("My Name is {0}", Process.GetCurrentProcess().ProcessName);
            ProcessThreadCollection ptc = myProc.Threads;
            foreach (ProcessThread pt in ptc)
            {
                Console.WriteLine("({0}) - {1}, {2}", pt.Id, pt.GetType(), pt.CurrentPriority);
            }

            Process browser = new Process();
            //browser.StartInfo.FileName = "C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe";
            //browser.StartInfo.Arguments = "http://www.cracked.com";
            //browser.Start();
            //Thread.Sleep(5000);
            //browser.Kill();

            //Launch a new thread to run my other method
            Thread other = new Thread(new ThreadStart(ThreadMethod));
            other.Name = "The other thingee";
            other.Start();

            for (int i = 0; i < 10; ++i)
            {
                Console.Write(i + ",");
                Thread.Sleep(25);
            }

            Console.ReadKey();
        }

        static void ThreadMethod()
        {
            string s = "abcdefghijklmnopqrstuvwzyz";
            foreach (char c in s)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
        }
    }
}
