using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anathema.adhed.DesignPatterns.FactoryTraining;

namespace UnitTests.adhed.SmartphoneFactory
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void ShouldGetPhoneFromFactory()
        {

            var factory = new Anathema.adhed.DesignPatterns.FactoryTraining.Factories.SmartphoneFactory();

            ISmartphone xiaomi = factory.GetElement("Xiaomi");

            Assert.AreEqual(xiaomi.Name, "Xiaomi");

        }
    }
}
