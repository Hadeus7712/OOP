using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Len(Point pnt)
        {
            return Math.Sqrt(Math.Pow(x - pnt.x, 2) + Math.Pow(y - pnt.y, 2));
        }
    }
}
