using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SumOfNNumbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum = sum + double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
