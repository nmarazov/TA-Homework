using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int transformations = 0;

            // while maslan's number has any digits left
            while (transformations < 10 && 9 < number)
            {
                BigInteger product = 1;

                // while maslan's number has any digits left
                while (number > 0)
                {
                    number /= 10;
                    string nString = number.ToString();
                    int oddSum = 0;

                    // take every odd digit, hence the starting from 1 and the update by 2
                    for (int i = 1; i < nString.Length; i += 2)
                    {
                        // convert char digit to it's corresponding int value
                        oddSum += nString[i] - '0';
                    }

                    // ignore 0 sums
                    if (oddSum != 0)
                    {
                        product *= oddSum;
                    }
                }

                // take the product of the sums and make it the new number
                number = product;
                // one more transformation has occurred
                transformations++;

                // take the product of the sums and make it the new number
                number = product;
                // one more transformation has occurred
                transformations++;
            }
            
            // if less than 10, print the count
            if (transformations < 10)
            {
                Console.WriteLine(transformations);
            }
            else if (transformations > 10)
            {
                // some reality check ;>
                throw new Exception("Should not happen");
            }

            // print answer
            Console.WriteLine(number);
        }
    }
}
