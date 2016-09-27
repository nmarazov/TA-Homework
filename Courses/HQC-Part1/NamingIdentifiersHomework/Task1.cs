namespace NamingIdentifiersHomework
{
    using System;

    public class ParentClass
    {
        private const int MaxCount = 6;

        public class ChildClass
        {
            public void PrintTrueOrFalse(bool input)
            {
                string printBool = input.ToString();
                Console.WriteLine(printBool);
            }
        }

        public static void PrintTrueOrFalseFromChildClass()
        {
            ChildClass childClass = new ChildClass();
            childClass.PrintTrueOrFalse(true);
        }
    }
}
