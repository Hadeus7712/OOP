using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLibrary;

namespace FiguresLibraryTests
{
    [TestClass]
    public class RhombusTests
    {
        [TestMethod]
        public void IsExistTest()
        {
            Point[] pnts = new Point[4];
            pnts[0] = new Point(0, 0);
            pnts[1] = new Point(0, 1);
            pnts[2] = new Point(1, 1);
            pnts[3] = new Point(1, 0);
            Rhombus testRhomb = new Rhombus(pnts);
            Assert.IsTrue(testRhomb.IsExist());
        }

        [TestMethod]
        public void CalcSidesTest()
        {
            Point[] pnts = new Point[4];
            pnts[0] = new Point(0, 0);
            pnts[1] = new Point(1, 1);
            pnts[2] = new Point(2, 0);
            pnts[3] = new Point(1, -1);
            Rhombus testRhomb = new Rhombus(pnts);
            Assert.AreEqual(testRhomb.CalcSides(), 1.4142, 0.001);
        }

        [TestMethod]
        public void STest()
        {
            Point[] pnts = new Point[4];
            pnts[0] = new Point(0, 0);
            pnts[1] = new Point(-1, 2);
            pnts[2] = new Point(0, 4);
            pnts[3] = new Point(1, 2);
            Rhombus testRhomb = new Rhombus(pnts);
            Assert.AreEqual(testRhomb.Square(), 4, 0.01);
        }

        [TestMethod]
        public void PTest()
        {
            Point[] pnts = new Point[4];
            pnts[0] = new Point(0, 0);
            pnts[1] = new Point(1, 1);
            pnts[2] = new Point(2, 0);
            pnts[3] = new Point(1, -1);
            Rhombus testRhomb = new Rhombus(pnts);
            Assert.AreEqual(testRhomb.Perimeter(), 5.6568, 0.01);
        }

        [TestMethod]
        public void IsBelongsToFigureTest()
        {
            Point[] pnts = new Point[4];
            pnts[0] = new Point(0, 0);
            pnts[1] = new Point(-1, 2);
            pnts[2] = new Point(0, 4);
            pnts[3] = new Point(1, 2);
            Rhombus testRhomb = new Rhombus(pnts);
            Assert.IsTrue(testRhomb.IsBelongsToFigure(0,2));
        }

        [TestMethod]
        public void IsBelongsToBorderTest()
        {
            Point[] pnts = new Point[4];
            pnts[0] = new Point(-2, 0);
            pnts[1] = new Point(0, 2);
            pnts[2] = new Point(2, 0);
            pnts[3] = new Point(0, -2);
            Rhombus testRhomb = new Rhombus(pnts);
            Assert.IsTrue(testRhomb.IsBelongsToBorder(1, 1));
        }
    }
}
