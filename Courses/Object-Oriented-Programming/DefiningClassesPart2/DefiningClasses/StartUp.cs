namespace Point3D
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var point = new Point3D(4.5, 8.4, 9.6);
            var anotherPoint = new Point3D(5.8, 9.7, 0.3);

            double distance = PointDistance.Distance(point, anotherPoint);

            Console.WriteLine(distance);
            Console.WriteLine(point);
            Console.WriteLine(Point3D.PointO);

            Console.WriteLine(new string('-', 50));

            Path testPath = new Path();
            Point3D point1 = new Point3D(1.5, 2.5, 3.5);
            Point3D point2 = new Point3D(-1, 2, 7);
            Point3D point3 = new Point3D(4, 2, 3);
            Point3D point4 = new Point3D(-5, -4, 3);
            Point3D point5 = new Point3D(1.25, 2.375, 3);

            testPath.AddPoint(point1);      
            testPath.AddPoint(point2);
            testPath.AddPoint(point3);
            testPath.AddPoint(point4);
            testPath.AddPoint(point5);

            PathStorage.SavePath(testPath, "sample"); 

            Path loadedPath = PathStorage.LoadPath(@"../../pointsample.txt"); 

            Console.WriteLine("The points from the text file are: ");
            for (int i = 0; i < loadedPath.PointList.Count; i++)
            {
                Console.WriteLine("Point {0}: {1}", i + 1, loadedPath.PointList[i].ToString());
            }
        }
    }
}