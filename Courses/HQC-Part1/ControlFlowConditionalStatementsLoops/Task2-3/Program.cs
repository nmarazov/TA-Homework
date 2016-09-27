using System;
using System.Collections.Generic;
namespace Task2_3
{
    public class Program
    {
        static void Main()
        {
            // Task 2 part 1
            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
            
            // Task 2 part 2
            if (minX <= x && x <= maxX && 
                minY <= y && y <= maxY && 
                shouldVisitCell)
            {
                VisitCell();
            }


            // Task 3
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
            }
        }
    }
}
