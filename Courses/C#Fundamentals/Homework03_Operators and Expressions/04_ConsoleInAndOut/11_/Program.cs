using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = N+1; i < M; i++)
            {
                if (i%5==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
