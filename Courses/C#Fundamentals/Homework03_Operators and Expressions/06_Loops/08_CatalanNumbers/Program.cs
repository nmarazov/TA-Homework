using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08_CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger upper = 1;
            BigInteger down = 1;
            BigInteger sum = 1;
            for (int i = (2 * n); i > n; i--)
            {
                upper = upper * i;
            }
            for (int i = (n + 1); i > 1; i--)
            {
                down = down * i;
            }
            sum = (upper / down);
            Console.WriteLine(sum);
        }
    }
}
