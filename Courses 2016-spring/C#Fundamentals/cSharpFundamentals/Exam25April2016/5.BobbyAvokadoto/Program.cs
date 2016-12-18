using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BobbyAvokadoto
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint c = uint.Parse(Console.ReadLine());
            uint[] combos = new uint[c];
            uint counter = 0;
            uint maxCounter = 0;
            uint bestCombo = 0;
                       
            //intput combos
            for (uint i = 0; i < c; i++)
            {
                combos[i] = uint.Parse(Console.ReadLine());
            }

            //best combo
            for (int i = 0; i < c; i++)
            {
                //for (int k = 0; k < 32; k++)
                //{
                //    if ((((combos[i] & (1 << k)) >> k) == 1) && (((number & (1 << k)) >> k) == 1))
                //    {
                //        break;
                //        i++;
                //    }
                    
                //}
                uint temp = combos[i] ^ number;

                for (int j = 0; j < 32; j++)
                {
                    if (((temp & (1 << j)) >> j) == 1)
                    {
                        counter++;
                    }
                }
                //save best combo
                if (maxCounter < counter)
                {
                    maxCounter = counter;
                    bestCombo = combos[i];
                }
                counter = 0;
            }

            Console.WriteLine(bestCombo);

            
        }
    }
}
