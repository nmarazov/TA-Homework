using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_MatrixofNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < (n + i); j++)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
            }
        }
    }
}
