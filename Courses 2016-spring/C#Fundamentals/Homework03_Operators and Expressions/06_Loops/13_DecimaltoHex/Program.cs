using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13_DecimaltoHex
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string hex = string.Empty;
            while (n > 0)
            {
                switch (n % 16)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        hex = n % 16 + hex;
                        break;
                    case 10:
                        hex = "A" + hex;
                        break;
                    case 11:
                        hex = "B" + hex;
                        break;
                    case 12:
                        hex = "C" + hex;
                        break;
                    case 13:
                        hex = "D" + hex;
                        break;
                    case 14:
                        hex = "E" + hex;
                        break;
                    case 15:
                        hex = "F" + hex;
                        break;
                    default:
                        break;
                }
                n /= 16;
            }
            Console.WriteLine(hex);
        }
    }
}