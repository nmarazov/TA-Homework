namespace Point3D
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pointList;

        public Path()
        {
            this.pointList = new List<Point3D>();
        }

        public List<Point3D> PointList
        {
            get
            {
                return this.pointList;
            }

            set
            {
                this.pointList = value;
            }
        }

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
