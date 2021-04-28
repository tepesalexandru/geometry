using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace geometry
{
    public class Line : Polygon
    {
        public List<Line> ls = new List<Line>();
        public Line (PointF p0, PointF p1)
        {
            Points = new PointF[] { p0, p1 };
            ls.Add(new Line(p0,p1));
        }
    }
}
