using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3rdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            if (v==0)
            {
                ulong mask = ~((ulong)1 << p);
                Console.WriteLine(n & mask);
            }
            else
            {
                ulong mask = (ulong)1 << p;
                Console.WriteLine(n | mask);
            }

        }
            
    }
}
