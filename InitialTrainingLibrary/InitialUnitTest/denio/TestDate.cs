using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialTrainingLibrary.denio.DateValidator;

namespace InitialUnitTest.denio
{
    [TestClass]
    public class TestDate
    {
        [TestMethod]
        public void denioDateTest()
        {
            DateValidator testDate = new DateValidator();
            Assert.IsTrue(testDate.DateValidate(2015, 2, 28));
            Assert.IsFalse(testDate.DateValidate(2012, 2, 30));
            Assert.IsTrue(testDate.DateValidate(1990, 12, 31));
            Assert.IsTrue(testDate.DateValidate(1987, 2, 27));
            Assert.IsFalse(testDate.DateValidate(1800, 13, 40));

        }
    }
}
