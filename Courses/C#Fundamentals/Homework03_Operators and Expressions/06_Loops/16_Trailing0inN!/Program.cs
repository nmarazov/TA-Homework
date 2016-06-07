using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Trailing0inN_
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 1;
            int zero = 0;

            while (input / Math.Pow(5, counter) >= 1)
            {
                zero += input / (int)(Math.Pow(5, counter));
                counter++;
            }
            Console.WriteLine(zero);
        }
    }
}
