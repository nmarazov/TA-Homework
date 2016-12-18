using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Busses
{
    class Program
    {
        static void Main()
        {
            int c = int.Parse(Console.ReadLine());
            int[] speed = new int[c];
            int numberOfGroups = 0;

            //input
            for (int i = 0; i < speed.Length; i++)
            {
                speed[i] = int.Parse(Console.ReadLine());
            }

            int temp = speed[0];
            for (int i = 0; i < speed.Length; i++)
            {
                if (temp >= speed[i])
                {
                    numberOfGroups++;
                    temp = speed[i];
                }
            }
            Console.WriteLine(numberOfGroups);

        }
    }
}
