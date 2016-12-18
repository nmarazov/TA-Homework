namespace Point3D
{
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path path, string pathIdentifier) // saves the file in the main project directory
        {
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathIdentifier + ".txt"))
            {
                foreach (Point3D point3D in path.PointList)
                {
                    sw.WriteLine(point3D);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }

            return path;
        }
    }
}
