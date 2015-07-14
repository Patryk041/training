using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.SemiRafista.TrainingTwoPESEL;

namespace Toci.Hornets.UnitTests.Rzeszow.SemiRafista
{
    [TestClass]
    public class SeRaPeselTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SeRaPeselValidator peselValidator = new SeRaPeselValidator();

            Assert.IsFalse(peselValidator.IsPeselValid("1234567890"));
            Assert.IsTrue(peselValidator.IsPeselValid("92071314764"));
            Assert.IsFalse(peselValidator.IsPeselValid("92071314752"));

        }
    }
}
