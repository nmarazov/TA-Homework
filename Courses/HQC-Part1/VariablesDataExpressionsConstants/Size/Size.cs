using System;

namespace Task1Size
{
    public class Size
    {
        private readonly double width;
        private readonly double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double rotateAngle)
        {
            double tempWidth = Math.Abs(Math.Cos(rotateAngle)) * size.width +
                Math.Abs(Math.Sin(rotateAngle)) * size.height;

            double tempHeight = Math.Abs(Math.Sin(rotateAngle)) * size.width +
                    Math.Abs(Math.Cos(rotateAngle)) * size.height;
            
            return new Size(tempWidth, tempHeight);
        }
    }
}
