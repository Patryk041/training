using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Matwie;

namespace Toci.BeginnersTest.TrainingOne.MatwieUnitTests
{
    [TestClass]
    public class MatwieTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MatwieDateValidator validator = new MatwieDateValidator();
            Assert.IsTrue(validator.CheckDate(1993, 7, 7));
            Assert.IsTrue(validator.CheckDate(2015, 8, 4));
            Assert.IsTrue(validator.CheckDate(2012, 2, 29));
            Assert.IsFalse(validator.CheckDate(2000000, 0, 0));
            Assert.IsFalse(validator.CheckDate(2000, 10, 0));
            Assert.IsFalse(validator.CheckDate(2013, 2, 29));
        }
    }
}
