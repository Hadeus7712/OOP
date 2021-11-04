using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLibrary;

namespace FiguresLibraryTests
{
    [TestClass]
    public class PntTests
    {
        [DataTestMethod()]
        [DataRow(1, 1, 2, 2, 1.4142)]
        [DataRow(0, 0, 1, 0, 1)]
        public void LenTest(double x1, double y1, double x2, double y2, double len)
        {
            double expLen = len;
            Point pnt1 = new Point(x1, y1);
            Point pnt2 = new Point(x2, y2);
            Assert.AreEqual(expLen, pnt1.Len(pnt2), 0.001, "Len is not correct");
        }
    }
}
