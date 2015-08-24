using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_classes_task4;

namespace HW_classes_task4_test
{
    [TestClass]
    public class InvoiceTest
    {
        Invoice invoice = new Invoice(1, "customer1", "article1", 6, 25.0);

        [TestMethod]
        public void GetAccountPriceWithoutVAT_Test()
        {
            double actual = invoice.GetAccountPriceWithoutVAT();
            double expected = 150;
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void GetAccountPriceWithVAT_Test()
        {
            double actual = invoice.GetAccountPriceWithVAT();
            double expected = 175.5;
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
