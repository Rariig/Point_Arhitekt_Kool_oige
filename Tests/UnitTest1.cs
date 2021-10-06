using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Point_Arhitekt_Kool_oige;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        Point a = new Point(5, 20);
        Point b = new Point(6, 4);

        [TestMethod]
        public void TestX()
        {
            Assert.AreEqual(5, a.X());
        }
        [TestMethod]
        public void TestY()
        {
            Assert.AreEqual(20, a.Y());
        }
        [TestMethod]
        public void TestRho()
        {
            Assert.AreEqual(Math.Sqrt(52), b.Rho());
        }

        [TestMethod]
        public void TestTheta()
        {
            Assert.AreEqual(0.59, b.Theta(), 0.01);
        }
        [TestMethod]
        public void TestVectorTo()
        {
            Point c = new Point(7, 16);
            Assert.AreEqual(-1, b.VectorTo(a).x);
            Assert.AreEqual(16, b.VectorTo(a).y);
        }

        [TestMethod]
        public void TestDistance()
        {
            Assert.AreEqual(Math.Sqrt(1 * 1 + 16 * 16), a.Distance(b));
        }

        [TestMethod]
        public void TestMove()
        {
            a.Move(5, 10);
            Assert.AreEqual(10, a.x);
            Assert.AreEqual(30, a.y);

        }

        [TestMethod]
        public void TestScale()
        {
            a.Scale(2);
            Assert.AreEqual(10, a.x);
            Assert.AreEqual(40, a.y);

        }

        [TestMethod]
        public void TestCentre_Rotate()
        {
            double oldTheta = a.Theta();
            a.Centre_rotate(1.3);
            Assert.AreEqual(oldTheta + 1.3, a.Theta());
        }

        [TestMethod]
        public void TestRotate()
        {
            double oldTheta = a.VectorTo(b).Theta();
            a.Rotate(b, 1.4);
            Assert.AreEqual(oldTheta + 1.4, a.VectorTo(b).Theta(), 0.01);
        }
    }
}
