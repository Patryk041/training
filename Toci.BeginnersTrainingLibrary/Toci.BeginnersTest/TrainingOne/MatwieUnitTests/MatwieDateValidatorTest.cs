using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Matwie;

namespace Toci.BeginnersTest.TrainingOne.MatwieUnitTests
{
    [TestClass]
    class MatwieDateValidatorTest
    {
        [TestMethod]
        public void TestMethod()
        {
            MatwieDateValidator validator = new MatwieDateValidator();
            Assert.IsTrue(validator.CheckDate(1993, 7, 7));
            Assert.IsTrue(validator.CheckDate(2015, 3, 4));
            Assert.IsTrue(validator.CheckDate(2012, 2, 29));
            Assert.IsFalse(validator.CheckDate(2000000, 0, 0));
            Assert.IsFalse(validator.CheckDate(2000, 10, 0));
            Assert.IsFalse(validator.CheckDate(2013, 2, 29));
        }
    }
}
