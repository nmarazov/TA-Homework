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
            ulong mask = 1U << p;
            Console.WriteLine((n & mask) >> p);
        }
    }
}
