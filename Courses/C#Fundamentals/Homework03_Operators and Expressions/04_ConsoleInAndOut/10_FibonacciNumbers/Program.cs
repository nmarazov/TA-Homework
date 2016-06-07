using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            ulong a1 = 0;
            ulong a2 = 0;
            ulong a = 0;
            if (N<=0)
            {
                Console.WriteLine(0);
            }
            for (int i = 1; i < N; i++)
            {
                if (a == 0)
                {
                    Console.Write("{0}",a);
                    a++;
                    a1 = a;
                }
                if (i == 2)
                {
                    Console.Write(", {0}", a);
                }
                else
                {
                    a = a1 + a2;
                    a2 = a1;
                    a1 = a;
                    Console.Write(", {0}", a);
                }
            }
        }
    }
}
