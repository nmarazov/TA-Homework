using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_16
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1002; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
	           	       Console.WriteLine(-1*i);
            }
        }
    }
}
