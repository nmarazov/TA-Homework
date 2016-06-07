using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BiggestOf5
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());
            if ((a > b) && (a > c) && (a > d) && (a > e))
            {
                Console.WriteLine(a);
            }
            else if ((b > a) && (b > c) && (b > d) && (b > e))
            {
                Console.WriteLine(b);
            }
            else if ((c > b) && (c > a) && (c > d) && (c > e))
            {
                Console.WriteLine(c);
            }
            else if ((d > b) && (d > c) && (d > a) && (d > e))
            {
                Console.WriteLine(d);
            }
            else if ((e > b) && (e > c) && (e > d) && (e > a))
            {
                Console.WriteLine(e);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
