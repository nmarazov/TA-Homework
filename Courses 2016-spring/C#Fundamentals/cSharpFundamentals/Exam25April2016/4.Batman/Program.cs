using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Batman
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            int head = n / 2;
            int body = n / 3;
            int tail = n / 2;

            // head loop
            for (int row = 0; row < head; row++)
            {
                
                //left wing
                Console.Write(new string(' ', row));
                Console.Write(new string(ch, n - row));

                //head
                if (row == head - 1)
                {
                    Console.Write(new string(' ', head - 1));
                    Console.Write(new string(ch, 1));
                    Console.Write(new string(' ', 1));
                    Console.Write(new string(ch, 1));
                    Console.Write(new string(' ', head - 1));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                
                //right wing
                Console.Write(new string(ch, n - row));
                Console.Write(new string(' ', row));

                Console.WriteLine();
            }

            //body loop
            for (int row = 0; row < body; row++)
            {
                Console.Write(new string(' ', head));
                Console.Write(new string(ch, n));
                Console.Write(new string(ch, 1));
                Console.Write(new string(ch, n));

                Console.WriteLine();
            }

            //tail loop
            for (int row = 0; row < tail; row++)
            {
                Console.Write(new string(' ', n + 1 + row));
                Console.Write(new string(ch, n - 2 - 2*row));

                Console.WriteLine();
            }
        }
    }
}
