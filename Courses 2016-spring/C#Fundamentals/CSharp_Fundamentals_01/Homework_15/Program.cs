using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DateTime today = DateTime.Now;
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            int age = today.Year - birthday.Year;
            if(today<birthday.AddYears(age))
            {
                age--;
            }
            Console.WriteLine(age);
            Console.WriteLine(age+10);
         }
    }
}
