using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Circle
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            const double PI = Math.PI;
            double Area = PI * r * r;
            double Prmtr = 2 * PI * r;
            Console.WriteLine("{0:0.00} {1:0.00}",Prmtr,Area);

        }
    }
}
