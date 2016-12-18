using System;
using System.Text;

namespace RotatingMatrix
{
    public class Matrix
    {
        private readonly int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private readonly int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public Matrix(int dimentions)
        {
            if (dimentions < 1)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(dimentions), 
                    "Matrix can not be created with less than 1 row and col");
            }

            this.MatrixField = new int[dimentions, dimentions];
            this.MatrixIndex = 1;
        }

        public int[,] MatrixField { get; private set; }

        public int MatrixIndex { get; private set; }

        public void BuildMatrix(Position currentPosition, Position nextPosition)
        {
            while (true)
            {
                this.MatrixField[currentPosition.X, currentPosition.Y] = this.MatrixIndex;

                if (this.IfMoveIsPosible(currentPosition))
                {
                    while (currentPosition.X + nextPosition.X >= this.MatrixField.GetLength(0) ||
                           currentPosition.X + nextPosition.X < 0 ||
                           currentPosition.Y + nextPosition.Y >= this.MatrixField.GetLength(1) ||
                           currentPosition.Y + nextPosition.Y < 0 ||
                           this.MatrixField[currentPosition.X + nextPosition.X, currentPosition.Y + nextPosition.Y] != 0)
                    {
                        this.ChangePosition(nextPosition);
                    }

                    currentPosition.X += nextPosition.X;
                    currentPosition.Y += nextPosition.Y;
                    this.MatrixIndex++;
                }
                else
                {
                    if (this.FindEmptyCell(out currentPosition))
                    {
                        nextPosition.X = 1;
                        nextPosition.Y = 1;
                        this.MatrixIndex++;
                        this.BuildMatrix(currentPosition, nextPosition);
                    }

                    // Break the loop if there is no more possible moves
                    break;
                }
            }
        }

        public string PrintMatrix()
        {
            var result = new StringBuilder();

            for (int i = 0; i < this.MatrixField.GetLength(0); i++)
            {
                for (int j = 0; j < this.MatrixField.GetLength(1); j++)
                {
                    result.Append(string.Format($"{this.MatrixField[i, j],3}"));
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        private bool FindEmptyCell(out Position firstEmptyPosition)
        {
            firstEmptyPosition = new Position(0, 0);

            for (int row = 0; row < this.MatrixField.GetLength(0); row++)
            {
                for (int col = 0; col < this.MatrixField.GetLength(0); col++)
                {
                    if (this.MatrixField[row, col] == 0)
                    {
                        firstEmptyPosition.X = row;
                        firstEmptyPosition.Y = col;
                        return true;
                    }
                }
            }

            return false;
        }

        private bool IfMoveIsPosible(Position currentPosition)
        {
            var tempDirectionsX = (int[])this.dirX.Clone();
            var tempDirectionsY = (int[])this.dirY.Clone();
            for (int i = 0; i < 8; i++)
            {
                if (currentPosition.X + this.dirX[i] >= this.MatrixField.GetLength(0) || currentPosition.X + this.dirX[i] < 0)
                {
                    tempDirectionsX[i] = 0;
                }

                if (currentPosition.Y + this.dirY[i] >= this.MatrixField.GetLength(0) || currentPosition.Y + this.dirY[i] < 0)
                {
                    tempDirectionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (this.MatrixField[currentPosition.X + tempDirectionsX[i], currentPosition.Y + tempDirectionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void ChangePosition(Position nextPosition)
        {
            int currentCount = 0;

            for (int count = 0; count < 8; count++)
            {
                if (this.dirX[count] == nextPosition.X && this.dirY[count] == nextPosition.Y)
                {
                    currentCount = count;
                    break;
                }
            }

            if (currentCount == 7)
            {
                nextPosition.X = this.dirX[0];
                nextPosition.Y = this.dirY[0];
                return;
            }

            nextPosition.X = this.dirX[currentCount + 1];
            nextPosition.Y = this.dirY[currentCount + 1];
        }
    }
}
