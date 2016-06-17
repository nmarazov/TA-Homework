namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int row = 4;
            int col = 4;
            var firstMatrix = new Matrix<int>(row, col);
            int counter = 1;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    firstMatrix[i, j] = counter;
                    counter++;
                }
            }

            Console.WriteLine(firstMatrix);

            row = 4;
            col = 4;
            counter = 1;
            var secondMatrix = new Matrix<int>(row, col);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    secondMatrix[i, j] = counter;
                    counter++;
                }
            }

            Console.WriteLine(secondMatrix);

            Console.WriteLine(firstMatrix + secondMatrix);
            Console.WriteLine(firstMatrix - secondMatrix);
            Console.WriteLine(firstMatrix * secondMatrix);
        }
    }
}
