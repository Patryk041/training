using System;
using Anathema.stpetersburgstakeout.linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anathema.Igor.AbstractFactory.Computers;
using Anathema.Igor.AbstractFactory;
using Anathema.Igor.Banks_New_Solution.AccountNumberValidator;
using Anathema.Igor.AbstractFactory.ComputerFactory;
using Anathema.Lurppis.TestDoLinQOperations;

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

        [TestMethod]
        public void TestFilteringWithLinq()
        {
            LinqOperations linqOperations = new LinqOperations();

            var result = linqOperations.GetDevelopersList("Developer");
        }

        [TestMethod]
        public void TestFilterProfession()
        {
            Tescik linqOperations = new Tescik();
            var result = linqOperations.GetProffesionList("adamW");
        }

        [TestMethod]
        public void AccountNumberValidatorTest()
        {
            AccountNumberValidator validator = new AccountNumberValidator("83101010230000261395100000");

            var isCorrect = validator.isAccountNumberCorrect();

            Assert.IsTrue(isCorrect);
        }
    }
}
