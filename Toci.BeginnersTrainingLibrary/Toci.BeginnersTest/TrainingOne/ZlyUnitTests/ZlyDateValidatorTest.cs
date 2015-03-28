using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Zly;

namespace Toci.BeginnersTest.TrainingOne
{
    [TestClass]
    public class ZlyDateValidatorTest
    {
        [TestMethod]

        public void ZlyTestValidatorMethod()
        {
            ZlyDateValidator testDateValidator = new ZlyDateValidator();
            Assert.IsTrue(testDateValidator.CheckDate(2013, 12, 21));
            Assert.IsTrue(testDateValidator.CheckDate(2012, 2, 29));
            Assert.IsFalse(testDateValidator.CheckDate(2013, 2, 29));
            Assert.IsTrue(testDateValidator.CheckDate(2013, 12, 21));
            Assert.IsTrue(testDateValidator.CheckDate(1993, 2, 21));
            Assert.IsTrue(testDateValidator.CheckDate(2015, 4, 31));



        }
    }
}

