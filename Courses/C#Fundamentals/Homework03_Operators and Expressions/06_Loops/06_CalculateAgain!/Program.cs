using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06_CalculateAgain_
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger result = 1;
            for (BigInteger i = n; i > k; i--)
            {
                result = result * i;
            }
            Console.WriteLine(result);

        }
    }
}
