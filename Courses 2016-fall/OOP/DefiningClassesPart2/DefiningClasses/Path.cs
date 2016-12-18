namespace Point3D
{
    using System.Collections.Generic;

    public class Path
    {
        public Path()
        {
            this.PointList = new List<Point3D>();
        }

        public List<Point3D> PointList { get; set; }

        public void AddPoint(Point3D point)
        {
            this.PointList.Add(point);
        }

        public void RemovePoint(int id)
        {
            this.PointList.RemoveAt(id);
        }
    }
}
