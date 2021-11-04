using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Rhombus
    {
        public Point[] points;
        public double[] sides = new double[4];
        /// <summary>
        /// Contructor of Rhombus
        /// </summary>
        public Rhombus()
        {
        }
        /// <summary>
        /// Contructor of Rhombus class, asign points and sides of rhombus
        /// </summary>
        /// <returns></returns>
        public Rhombus(Point[] points)
        {
            this.points = points;
            sides[0] = points[0].Len(points[1]);
            sides[1] = points[1].Len(points[2]);
            sides[2] = points[2].Len(points[3]);
            sides[3] = points[3].Len(points[0]);
        }
        /// <summary>
        /// Method that verify that rhombus exists
        /// </summary>
        /// <returns></returns>
        public bool IsExist()
        {
            if (sides[0] != 0 && sides[0] == sides[1] &&
                sides[1] == sides[2] &&
                sides[2] == sides[3])
                return true;
            else
                return false;
        }
        /// <summary>
        /// method that calculate sideos of rhombus
        /// </summary>
        /// <returns></returns>
        public double CalcSides()
        {
            return sides[0];
        }
        /// <summary>
        /// method that calculate square of the rhombus
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            return points[0].Len(points[2]) * points[1].Len(points[3]) * 0.5;
        }
        /// <summary>
        /// method that calculate perimeter of the rhombus
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return 4 * sides[0];
        }
        /// <summary>
        /// method that verify dot IS in the rhombus or not
        /// </summary>
        /// <returns></returns>
        public bool DoesBelongsToFigure(double x, double y)
        {
            Point pnt = new Point(x, y);
            double ExpS = GeronsFurmula(pnt.Len(points[0]), pnt.Len(points[1]), sides[0]);
            ExpS += GeronsFurmula(pnt.Len(points[1]), pnt.Len(points[2]), sides[1]);
            ExpS += GeronsFurmula(pnt.Len(points[2]), pnt.Len(points[3]), sides[2]);
            ExpS += GeronsFurmula(pnt.Len(points[3]), pnt.Len(points[0]), sides[3]);
            if (Math.Round(ExpS, 5, MidpointRounding.AwayFromZero) == Math.Round(Square(), 5, MidpointRounding.AwayFromZero))
                return true;
            else
                return false;
        }
        /// <summary>
        /// does point belongs to side of rhombus
        /// </summary>
        /// <returns></returns>
        public bool DoesBelongsToBorder(double x, double y)
        {
            Point pnt = new Point(x, y);
            if (pnt.Len(points[0]) + pnt.Len(points[1]) == sides[0] ||
                pnt.Len(points[1]) + pnt.Len(points[2]) == sides[1] ||
                pnt.Len(points[2]) + pnt.Len(points[3]) == sides[2] ||
                pnt.Len(points[3]) + pnt.Len(points[0]) == sides[3])
                return true;
            else
                return false;
        }
        /// <summary>
        /// calculate square of triangle via Geron's method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private double GeronsFurmula(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Pow(p * (p - a) * (p - b) * (p - c), 1.0 / 2.0);
        }
    }
}

