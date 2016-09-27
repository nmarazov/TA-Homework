using System;
using System.Collections.Generic;

namespace RotatingMatrix
{
    public class Position
    {
        private int x;
        private int y;

        public Position(int positionX, int positionY)
        {
            this.X = positionX;
            this.Y = positionY;
        }

        public int X
        {
            get
            {
                return this.x;
            }

            internal set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.X), "Position in matrix is invalid.");
                }

                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            internal set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.Y), "Position in matrix is invalid.");
                }

                this.y = value;
            }
        }
    }
}
