using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b =  a % 2;
            if (b == 0)
            {
                Console.WriteLine("even {0}",a);
            }
            else
            {
                Console.WriteLine("odd {0}",a);
            }
        }
    }
}
