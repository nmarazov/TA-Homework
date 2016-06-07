using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Calculate_
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double result = 1;
            int factorial = 1;
            double power = 1;
            for (int i = 1 ; i <= N; i++)
            {
                factorial = factorial * i;
                power = (Math.Pow(x, i));
                result += (factorial / power);
            }
            Console.WriteLine("{0:F5}", result);
        }
    }
}
