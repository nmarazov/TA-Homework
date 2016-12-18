using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            int temp;
            int d = Number % 10;
            temp = Number / 10;
            int c = temp % 10;
            temp = temp / 10;
            int b = temp % 10;
            temp = temp / 10;
            int a = temp;
            Console.WriteLine(a + b + c + d);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
