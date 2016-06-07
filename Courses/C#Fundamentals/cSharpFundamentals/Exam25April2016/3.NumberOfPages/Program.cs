using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.NumberOfPages
{
    class Program
    {
        static void Main()
        {
            int D = int.Parse(Console.ReadLine());
            int page = 0;
            int temp = 0;
            int result = 0;
            for (int i = 0; i < 6; i++)
            {
                if (D < 10)
                {
                    page = D;
                }
                temp += 9 * (i + 1) * (int)Math.Pow(10, i);
                if (temp > D)
                {
                    page += (result / (i+1));
                    break;
                }
                page += 9 * (int)Math.Pow(10, i);
                result = D - temp;
                
            }
            Console.WriteLine(page);
        }
    }
}
