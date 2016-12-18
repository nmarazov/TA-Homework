namespace GenericClass
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstList = new GenericList<int>();

            for (int i = 0; i < 6; i++)
            {
                firstList.Add(i);
            }

            Console.WriteLine("Initialize GenericList");
            Console.WriteLine(firstList);

            Console.WriteLine("Add item at index 3");
            firstList.AddAtIndex(10, 3);
            Console.WriteLine(firstList);

            Console.WriteLine("Deleted item at index 3");
            firstList.DeleteAtIndex(3);
            Console.WriteLine(firstList);

            Console.WriteLine("Min item In the array is: {0}", firstList.Min());
            Console.WriteLine("Max item In the array is: {0}", firstList.Max());
        }
    }
}
