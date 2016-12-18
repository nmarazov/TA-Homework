using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_DecimaltoBinary
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string binary = "";
            for (int i = 0; n > 0; i++)
            {
                if (n % 2 == 0)
                {
                    binary = binary.Insert(i, "0");
                }
                else
                {
                    binary = binary.Insert(i, "1");
                }
                n = n / 2;
            }
            for (int i = 1; i <= binary.Length; i++)
            {
                Console.Write(binary[binary.Length - i]);
            }
            Console.WriteLine();
            Console.WriteLine(binary.PadLeft(32,'0'));
            binary = Convert.ToString(n,2);
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(p, 16).PadLeft(32, '0'));
        }
    }
}
