using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_IntDoubleString
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            if ((type == "int") || (type == "integer"))
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a+1);
            }
            else if ((type == "double") || (type == "real"))
            {
                double a = double.Parse(Console.ReadLine());
                a = a + 1;
                Console.WriteLine("{0:0.00}",a);
            }
            else if ((type == "text") || (type == "string"))
            {
                string a = Console.ReadLine();
                Console.WriteLine("{0}*",a);
            }
        }
    }
}
