using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anathema.Igor.AbstractFactory.Computers;
using Anathema.Igor.AbstractFactory;
using Anathema.Igor.AbstractFactory.ComputerFactory;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ComputerFactory computers = new ComputerFactory();

            IComputer computer = computers.getElement("Apple");

            Assert.AreEqual("ASUS", computer.getName());
        }
    }
}
