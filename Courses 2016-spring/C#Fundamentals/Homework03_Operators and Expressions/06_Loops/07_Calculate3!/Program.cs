using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07_Calculate3_
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger upper = 1;
            BigInteger down = 1;
            BigInteger sum = 1;
            for (int i = n; i > k; i--)
            {
                upper = upper * i;
            }
            for (int i = (n-k); i > 1; i--)
            {
                down = down * i;
            }
            sum = (upper / down);
            Console.WriteLine(sum);
        }
    }
}
