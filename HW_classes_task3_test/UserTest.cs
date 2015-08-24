using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_classes_task3;

namespace HW_classes_task3_test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserTest1()
        {
            DateTime dt = new DateTime(2008, 6, 23);
            User user = new User("alinka", "Alina", "Bila", 21, dt);
            
        }
    }
}
