using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_classes;

namespace HW_classes_task1_test
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void Area_WithNormalRectangle()
        {
            double side1 = 25;
            double side2 = 12.346;
            double actualArea = new Rectangle(side1, side2).Area;
            double expectedArea = 308.65;

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [TestMethod]
        public void Perimeter_WithNormalRectangle()
        {
            double side1 = 25;
            double side2 = 12.346;
            double actualArea = new Rectangle(side1, side2).Perimeter;
            double expectedArea = 74.692;

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Sides can`t be negative")]
        public void NegativeRectangleSides()
        {
            Rectangle rectangle = new Rectangle(-1.9, 9.9);
        }
    }
}
