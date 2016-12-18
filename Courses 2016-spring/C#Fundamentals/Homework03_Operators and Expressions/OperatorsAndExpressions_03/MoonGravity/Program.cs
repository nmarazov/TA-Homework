using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class Program
    {
        static void Main(string[] args)
        {
            float W=float.Parse(Console.ReadLine());
            float mW = W * 17 / 100;
            Console.WriteLine(mW.ToString("0.000"));
        }
    }
}
