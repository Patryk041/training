using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator;

namespace Toci.BeginnersTest.TrainingOne.DoktorUnitTests
{
    [TestClass]
    public class DoktorDateValidatorTest
    {
        [TestMethod]
        public void DoktorDateValidationTest()
        {
            DoktorDateValidator date = new DoktorDateValidator();
            Assert.IsFalse(date.CheckDate(11, 04, 2015));
        }
    }
}
