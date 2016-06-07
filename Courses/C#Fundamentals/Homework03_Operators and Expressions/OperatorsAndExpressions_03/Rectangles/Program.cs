using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double P = 2 * (width + height);
            double A = width * height;
            Console.WriteLine("{0:0.00} {1:0.00}",A,P);
        }
    }
}
