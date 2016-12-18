using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = (21 << 2) ^ 123415;
            Console.WriteLine(Convert.ToString((uint)1<<31, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(2147483648, 2).PadLeft(32,'0'));
            Console.WriteLine(Convert.ToString(23, 2).PadLeft(32,'0'));
            Console.WriteLine(Convert.ToString(15, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(23 ^ 2344, 2).PadLeft(32, '0'));
            Console.WriteLine((uint)1<<31);
        }
    }
}
