using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_classes_task2;

namespace HW_classes_task2_test
{
    [TestClass]
    public class FigureTest
    {
        Point p1 = new Point(-2, 0, "p1");
        Point p2 = new Point(-2, 2, "p2");
        Point p3 = new Point(2, 2, "p3");
        Point p4 = new Point(2, -3, "p4");
        Point p5 = new Point(0, 10, "p5");

        [TestMethod]
        public void PerimeterCalculator_WithThreePoints()
        {
            double actualPerimeter = new Figure(p1, p2, p3).PerimeterCalculator();
            double expectedPerimeter = 10.47;

            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.01);
        }

        [TestMethod]
        public void PerimeterCalculator_WithFourPoints()
        {
            double actualPerimeter = new Figure(p1, p2, p3, p4).PerimeterCalculator();
            double expectedPerimeter = 16;

            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.01);
        }

        [TestMethod]
        public void PerimeterCalculator_WithFivePoints()
        {            
            double actualPerimeter = new Figure(p1, p2, p3, p4, p5).PerimeterCalculator();
            double expectedPerimeter = 34.350;

            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.01);
        }
    }
}
