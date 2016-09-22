using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchTests
{
    public class Program
    {
        public static void DisplayActionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
        public static void Main()
        {
            // Simple Math
            int loopcount = 10000000;

            int intnumber = 1;
            long longnumber = 100000000000;
            float floatnumber = 1.0f;
            double doublenumber = 1.0d;
            decimal decimalnumber = 101.1m;

            Console.WriteLine("ADD:");
            Console.Write("int:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    intnumber += 1;
                }
            });
            Console.Write("long:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    longnumber += 1;
                }
            });
            Console.Write("float:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    floatnumber += 1.1f;
                }
            });
            Console.Write("double:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    doublenumber += 1.1;
                }
            });
            Console.Write("decimal:");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    decimalnumber += 1.1m;
                }
            });

            //SUBTRACT
            Console.WriteLine("SUBTRACT:");
            Console.Write("int:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    intnumber -= 1;
                }
            });
            Console.Write("long:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    longnumber -= 1;
                }
            });
            Console.Write("float:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    floatnumber -= 1.1f;
                }
            });
            Console.Write("double:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    doublenumber -= 1.1;
                }
            });
            Console.Write("decimal:");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    decimalnumber -= 1.1m;
                }
            });

            // MULTIPLY
            Console.WriteLine("MULTIPLY:");
            Console.Write("int:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    intnumber *= 3;
                }
            });
            Console.Write("long:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    longnumber *= 3;
                }
            });
            Console.Write("float:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    floatnumber *= 1.1f;
                }
            });
            Console.Write("double:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    doublenumber *= 1.1;
                }
            });
            Console.Write("decimal:");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    decimalnumber *= 1m;
                }
            });

            // divide
            Console.WriteLine("divide:");
            Console.Write("int:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    intnumber /= 3;
                }
            });
            Console.Write("long:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    longnumber /= 3;
                }
            });
            Console.Write("float:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    floatnumber /= 1.1f;
                }
            });
            Console.Write("double:\t");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    doublenumber /= 1.1;
                }
            });
            Console.Write("decimal:");
            DisplayActionTime(() =>
            {
                for (int i = 0; i < loopcount; i++)
                {
                    decimalnumber /= 1.1m;
                }
            });
        }
    }
}
