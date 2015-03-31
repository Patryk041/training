using System;
using InitialTrainingLibrary.Wiosna.DateValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.BeginnersTest.TrainingOne.WiosnaUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WiosnaDateValidator date  = new WiosnaDateValidator();
            Assert.IsTrue(date.CheckDate(29,02,2012));
            Assert.IsFalse(date.CheckDate(34,12,2015));
            Assert.IsFalse(date.CheckDate(02,14,2015));
        }
    }
}
