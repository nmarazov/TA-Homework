using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = N / 100;
            int third = M % 10;
            Console.WriteLine(third == 7 ? "true" : "false {0}",third);


        }
    }
}
