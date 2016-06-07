using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_BinarytoDecimal
{
    class Program
    {
        static void Main()
        {
            int number = 0;
            string binary = Console.ReadLine();

            for (int i = 0; i < binary.Length; i++)
            {
                number += (binary[i] - '0') * (1 << (binary.Length - i - 1));
            }
            Console.WriteLine(number);
        }
    }
}
