using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int allSheets = students * sheets;
            double realms = allSheets / 400.0;
            Console.WriteLine("{0:F3}",price * realms);
        }
    }
}
