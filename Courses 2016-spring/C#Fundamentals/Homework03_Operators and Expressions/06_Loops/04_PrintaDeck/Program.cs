using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PrintaDeck
{
    class Program
    {
        static void Main()
        {
            List<string> deck = new List<string>() {"J", "Q", "K", "A"};
            string symbol = Console.ReadLine();
            switch (symbol)
            {
                case "2":
                    for (int i = 2 ; i <= 2; i++)
                    {
                        Console.Write("{0} of spades, ",i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    break;
                case "3":
                    for (int i = 2; i <= 3; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    break;
                case "4":
                    for (int i = 2; i <= 4; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    break;
                case "5":
                    for (int i = 2; i <= 5; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    break;
                case "6":
                    for (int i = 2; i <= 6; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    break;
                case "7":
                    for (int i = 2; i <= 7; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    break;
                case "8":
                    for (int i = 2; i <= 8; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    break;
                case "9":
                    for (int i = 2; i <= 9; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    break;
                case "10":
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    break;
                case "J":
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write("{0} of spades, ", deck[i]);
                        Console.Write("{0} of clubs, ", deck[i]);
                        Console.Write("{0} of hearts, ", deck[i]);
                        Console.Write("{0} of diamonds ", deck[i]);
                        Console.WriteLine();
                    }
                    break;
                case "Q":
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write("{0} of spades, ", deck[i]);
                        Console.Write("{0} of clubs, ", deck[i]);
                        Console.Write("{0} of hearts, ", deck[i]);
                        Console.Write("{0} of diamonds ", deck[i]);
                        Console.WriteLine();
                    }
                    break;
                case "K":
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("{0} of spades, ", deck[i]);
                        Console.Write("{0} of clubs, ", deck[i]);
                        Console.Write("{0} of hearts, ", deck[i]);
                        Console.Write("{0} of diamonds ", deck[i]);
                        Console.WriteLine();
                    }
                    break;
                case "A":
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.Write("{0} of spades, ", i);
                        Console.Write("{0} of clubs, ", i);
                        Console.Write("{0} of hearts, ", i);
                        Console.Write("{0} of diamonds ", i);
                        Console.WriteLine();
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write("{0} of spades, ", deck[i]);
                        Console.Write("{0} of clubs, ", deck[i]);
                        Console.Write("{0} of hearts, ", deck[i]);
                        Console.Write("{0} of diamonds ", deck[i]);
                        Console.WriteLine();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
