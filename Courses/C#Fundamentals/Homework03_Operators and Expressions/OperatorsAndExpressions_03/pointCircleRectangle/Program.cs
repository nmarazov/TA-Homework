using System;

class PointCircleRectangle
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double point = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));
        bool isInCircle = (point <= 1.5);
        bool isOutsideRectangle = (x < -1 || x > 5 || y > 1 || y < -1);
        if ((isInCircle == true) && (isOutsideRectangle == true))
        {
            Console.WriteLine("{0} {1}", "inside circle", "outside rectangle");
        }
        else
            if ((isInCircle == true) && (isOutsideRectangle == false))
        {
            Console.WriteLine("{0} {1}", "inside circle", "inside rectangle");
        }
        else
            if ((isInCircle == false) && (isOutsideRectangle == true))
        {
            Console.WriteLine("{0} {1}", "outside circle", "outside rectangle");
        }
        else
        {
            Console.WriteLine("{0} {1}", "outside circle", "inside rectangle");
        }

    }
}