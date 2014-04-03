using System;
using System.Threading;
using System.Drawing;

namespace Demo_9
{
    class MainClass
    {
        static Random rand = new Random ();
        static object TheOneTrueRing = new object();
        static string TheOneString = null;
        public static void Main (string[] args)
        {

            Dance();
            //Below won't work, because signature doesn't match delegate.
            //Thread dancer1 = new Thread(new ThreadStart(Dance));

            //But:
            object[] parameters = null;
            Thread dancer1 = new Thread (new ParameterizedThreadStart (Dancer));
            parameters = new object[]{ "Get on down.  Get on down and dance!", '1', 200u, 20u, ConsoleColor.Red };
            dancer1.IsBackground=true;
            dancer1.Start (parameters);
            //dancer1.Join();


            Thread dancer2 = new Thread(new ParameterizedThreadStart(Dancer));
            parameters = new object[] { "Stop!  Hammuh Tyme!", '2', 400u, 10u, ConsoleColor.Blue };
            dancer2.IsBackground = true;
            dancer2.Start(parameters);
            dancer2.Join();

            //Wait for other threads...
            //Thread.Sleep (500);
            //Kill them if they can't take a joke.
            //System.Environment.Exit (System.Environment.ExitCode);
            Console.WriteLine(TheOneString == null ? "Meh. Nothing Retrieved" : "I Retrieved: " + TheOneString);
            Console.Write("\n\nPress Enter to Exit\n\n");
            Console.Read();
        }


        public static string Dance(string start = "Hammer Time!", char precede = ' ',
            uint delay = 0, uint count = 10, ConsoleColor cc = ConsoleColor.Green)
        {
            object MyPrecious = new object();
            Console.OutputEncoding = System.Text.Encoding.Unicode; //Because Microsoft sux0rz.
            //char[] symbols = { '\u2b05', '\u2b06', '\u2b07', '\u2b08', '\u2b09', '\u2b0a', '\u2b0b', '\u2b0c', '\u2b0d' };
            char[] symbols = { '\u00A0', '\u00A1', '\u00A2', '\u00A3', '\u00A4', '\u00A5', '\u00A6', '\u00A7', '\u00A8' };
            Console.WriteLine (start);
            //lock (MyPrecious) // Won't work!  It can't be local!
            //lock (rand) //Any old object will do! 
            //lock(TheOneTrueRing)
            {
                for (int i = 0; i < count; ++i)
                {
                    if (delay > 0) Thread.Sleep((int)delay);
                    lock (TheOneTrueRing) //Appropriate use of lock to protect colored console output
                    {
                        Console.ForegroundColor = cc;
                        Console.Write(precede);
                        //Print a random element of symbols.
                        Console.Write(symbols[rand.Next(symbols.Length)]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            Console.WriteLine();
            return start;
        }

        //Wrapper function for Dancer
        public static void Dancer(object stuff)
        {
            //lock (TheOneTrueRing) //Can also use locks to protect a return value.  Kinda kludgy.
            {
                object[] pars = (object[])stuff;
                TheOneString = Dance((string)pars[0], (char)pars[1], (uint)pars[2], (uint)pars[3], (ConsoleColor)pars[4]);
            }
        }
    }
}
