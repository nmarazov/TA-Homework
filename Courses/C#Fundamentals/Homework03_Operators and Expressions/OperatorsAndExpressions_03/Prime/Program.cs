using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (N < 2)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "true" : "false");
         }
    }
}
