using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclareVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort a = 52130;
            sbyte b = -115;
            int c = 4825932;
            byte d = 97;
            short e = -10000;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            double a1 = 34.567839023;
            double a2 = 8923.1234857;
            float a3 = 12.345f;
            float a4 = 3456.091f;

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);

            int b2 = 0xfe;
            Console.WriteLine(b2);

            Console.WriteLine('\u002A');

            bool isFemale = false;
            Console.WriteLine(isFemale);

            string c1 = "Hello";
            string c2 = " World";
            object c3 = c1 + c2;
            string c4;
            c4 = (string)c3;
            Console.WriteLine(c4);

            string first;
            string second;
            byte age;
            char gender;
            string idNumber;
            string empNumber;

            Console.WriteLine("Enter your personal information:");
            Console.WriteLine("First Name:");
            first = Console.ReadLine();
            Console.WriteLine("Second Name:");
            second = Console.ReadLine();
            Console.WriteLine("age");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("gender");
            gender = char.Parse(Console.ReadLine());

            Console.Write(first);
            Console.WriteLine(second);
            Console.WriteLine(age);
            Console.WriteLine(gender);





        }
    }
}
