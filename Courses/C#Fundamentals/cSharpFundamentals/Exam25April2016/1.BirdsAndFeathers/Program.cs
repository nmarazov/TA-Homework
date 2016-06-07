using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BirdsAndFeathers
{
    class Program
    {
        static void Main()
        {
            int birds = int.Parse(Console.ReadLine());
            int totalFeathers = int.Parse(Console.ReadLine());
            double result = (totalFeathers / (double)birds);

            if (birds % 2 == 0)
            {
                result *= 123123123123;
            }
            else
            {
                result /= 317;
            }
            Console.WriteLine("{0:0.0000}",result);
        }
    }
}
