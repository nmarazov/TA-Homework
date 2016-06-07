using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MMSAofNNumbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            List<double> numbers = new List<double>();
            for (int i = 0; i < N; i++)
            {
                double temp = double.Parse(Console.ReadLine());
                numbers.Add(temp);
            }
            Console.WriteLine("min={0:0.00}", numbers.Min());
            Console.WriteLine("max={0:0.00}", numbers.Max());
            Console.WriteLine("sum={0:0.00}", numbers.Sum());
            Console.WriteLine("avg={0:0.00}", numbers.Average());
        }
    }
}
