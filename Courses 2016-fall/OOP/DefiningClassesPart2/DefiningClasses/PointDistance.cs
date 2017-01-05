namespace Point3D
{
    using System;

    public static class PointDistance
    {
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            var distance = Math.Sqrt(Math.Abs(firstPoint.X - secondPoint.X) * Math.Abs(firstPoint.X - secondPoint.X) +
                                        Math.Abs(firstPoint.Y - secondPoint.Y) * Math.Abs(firstPoint.Y - secondPoint.Y) +
                                        Math.Abs(firstPoint.Z - secondPoint.Z) * Math.Abs(firstPoint.Z - secondPoint.Z));

            return distance;
        }
    }
}
