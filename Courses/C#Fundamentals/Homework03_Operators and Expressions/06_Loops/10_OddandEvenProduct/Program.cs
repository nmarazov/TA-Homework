using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10_OddandEvenProduct
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            BigInteger oddProduct = 1;
            BigInteger evenProduct = 1;
            for (int i = 0; i < numbers.Length; i+=2)
            {
                oddProduct *= int.Parse(numbers[i]);
            }
            for (int i = 1; i < numbers.Length; i += 2)
            {
                evenProduct *= int.Parse(numbers[i]);
            }
            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes {0}",evenProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}",oddProduct,evenProduct);
            }
        }
    }
}
