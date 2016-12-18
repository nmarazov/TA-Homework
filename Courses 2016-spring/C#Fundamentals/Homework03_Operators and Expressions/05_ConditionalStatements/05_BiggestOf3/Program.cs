using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BiggestOf3
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine(a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine(b);
            }
            else if ((c > a) && (c > b))
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
