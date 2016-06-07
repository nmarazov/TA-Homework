using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b,2) - 4 * a * c;
            double x1 = (-b - Math.Sqrt(D)) / (2 * a);
            double x2 = (-b + Math.Sqrt(D)) / (2 * a);
            if (D > 0)
            {
                if (x1 < x2)
                {
                    Console.WriteLine("{0:0.00}", x1);
                    Console.WriteLine("{0:0.00}", x2);
                }
                else
                {
                    Console.WriteLine("{0:0.00}", x2);
                    Console.WriteLine("{0:0.00}", x1);
                }
            }
                
            else if ( D==0 )
            {
                Console.WriteLine( "{0:0.00}",x1 );
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
