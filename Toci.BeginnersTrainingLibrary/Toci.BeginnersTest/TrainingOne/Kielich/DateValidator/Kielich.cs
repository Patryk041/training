using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Kielich;
using Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.DateValidator;

namespace Toci.BeginnersTest
{
    [TestClass]
    public class Kielich
    {
        [TestMethod]
        public void TestMethod()
        {
            KielichDateValidator Test = new KielichDateValidator();
            Assert.IsFalse(Test.CheckDate(1506, 2, 28));
            Assert.IsTrue(Test.CheckDate(1806, 2, 01));
            Assert.IsFalse(Test.CheckDate(2006, 15, 33));
        }
    }
}

        

