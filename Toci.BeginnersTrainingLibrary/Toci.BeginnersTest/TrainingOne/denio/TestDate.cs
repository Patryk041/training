using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator;


namespace Toci.BeginnersTest.TrainingOne.denio
{
    [TestClass]
    public class TestDate
    {
        [TestMethod]
        public void denioDateTest()
        {
            DateValidator testDate = new DateValidator();
            Assert.IsTrue(testDate.CheckDate(2015, 2, 28));
            Assert.IsFalse(testDate.CheckDate(2012, 2, 30));
            Assert.IsTrue(testDate.CheckDate(1990, 12, 31));
            Assert.IsTrue(testDate.CheckDate(1987, 2, 27));
            Assert.IsFalse(testDate.CheckDate(1800, 13, 40));

        }
    }
}
