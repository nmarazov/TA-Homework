using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string e = Console.ReadLine();
            string f = Console.ReadLine();
            string g = Console.ReadLine();
            string h = Console.ReadLine();
            string i = Console.ReadLine();
            if (d=="")
            {
                d = "(no fax)";
            }
            Console.WriteLine(a);
            Console.WriteLine("Address: {0}",b);
            Console.WriteLine("Tel. {0}",c);
            Console.WriteLine("Fax: {0}",d);
            Console.WriteLine("Web site: {0}",e);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",f,g,h,i); 
        }
    }
}
