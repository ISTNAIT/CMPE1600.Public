using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Demo_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's find out about our processes
            //Process p = Process.GetCurrentProcess();
            //Console.WriteLine("About me: " + p.ProcessName + "(" + p.Id + ")"
            //    + " - " + p.PriorityClass + "(" + p.PagedMemorySize64 + ")");

            //Process[] ps = Process.GetProcesses();
            //Console.WriteLine("About us:");
            //foreach(Process s in ps)
            //    Console.WriteLine(s.ProcessName + "(" + s.Id + ")");

            //What happens with no threading at all?
            //SimpleThread();
            //ParamaThread();
            //Console.ReadKey();

            //Let's try putting them in a thread.
            Thread simpleton = new Thread(new ThreadStart(SimpleThread));
            simpleton.Start();
            //ParamaThread(); //This will run inside the main thread
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < 5; ++i )
            {
                Thread t = new Thread(new ParameterizedThreadStart(PTWrapper));
                object[] pars = new object[5];
                pars[0] = "I am thread number " + i;
                pars[1] = (char)('a' + i);
                pars[2] = (uint) (i * 100);
                pars[3] = 10u;
                pars[4] = ConsoleColor.Green + i;
                t.Start(pars);
            }

                Console.ReadKey();
        }

        //For simple no-parameter ThreadStart
        public static void SimpleThread()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I am a simple thread.  Love me!");
            for(int i = 0; i < 10; ++i)
            {
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(i + " ");
            }
        }

        //For parmaterized Threadstart
        public static string ParamaThread(string start = "Ready to go!",
                                          char firstChar = 'a',
                                          uint delay = 250,
                                          uint count = 10,
                                          ConsoleColor cc = ConsoleColor.Red)
        {
            Console.ForegroundColor = cc;
            Console.WriteLine(start);
            for(int i = 0; i < count; ++i)
            {
                Thread.Sleep((int)delay);
                Console.ForegroundColor = cc;
                Console.Write(firstChar++ + " ");
            }
            return "I is done! Yayz!";
        }

        //Wrapper for calling ParamaThread
        public static void PTWrapper(object stuff)
        {
            object[] pars = null;

            //Can I legally convert this thing to an array
            if(stuff is object[])
                 pars = (object[]) stuff;
            else
                throw new Exception("That thing ain't raaaght.");

            Console.WriteLine(ParamaThread((string) pars[0],
            (char) pars[1], (uint) pars[2], (uint) pars[3], (ConsoleColor) pars[4]));
        }

    }
}
