using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Recha;

namespace Toci.BeginnersTest.TrainingOne.Recha
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
