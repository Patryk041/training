using System;
using InitialTrainingLibrary.Wiosna.DateValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.Wiosna
{
    [TestClass]
    public class WiosnaUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            WiosnaDateValidator date =  new WiosnaDateValidator();

            Assert.IsTrue(date.DateValidate(01, 09, 2015));
            Assert.IsTrue(date.DateValidate(13, 05, 1993));
            Assert.IsTrue(date.DateValidate(04,03,2000));
            Assert.IsFalse(date.DateValidate(29,02,2015));
            Assert.IsFalse(date.DateValidate(34,09,2015));
            Assert.IsFalse(date.DateValidate(12, 13, 2015));
            Assert.IsFalse(date.DateValidate(12, 10, 0));
        }
    }
}
