using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskLibrary_my;
using System;

namespace GeometryTests {
    [TestClass]
    public class GeometryTests_my {
        [TestMethod]
        public void RectangleArea_2and3_6returned() {
            int a = 2; int b = 3;
            int expected = 6;

            Geometry_my g = new Geometry_my();
            int actual = g.RectangleArea(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VolumeCylinder_test() {
            int R = 3;
            int H = 5;
            double expected = Math.PI * Math.Pow(R, 2) * H;
            Geometry_my g2 = new Geometry_my();
            double actual = g2.VolumeCylinder(R, H);
            Assert.AreEqual(expected, actual);
        }
    }
}
