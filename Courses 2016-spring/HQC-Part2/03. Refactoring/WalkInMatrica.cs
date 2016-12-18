using System;

namespace RotatingMatrix
{
    internal class WalkInMatrica
    {
        private static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int n;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            var currentPosition = new Position(0, 0);
            var nextPosition = new Position(1, 1);
            var matrix = new Matrix(n);
            matrix.BuildMatrix(currentPosition, nextPosition);
            Console.WriteLine(matrix.PrintMatrix());
        }
    }
}
