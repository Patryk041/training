using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Amman.DateValidator;

namespace Toci.BeginnersTest.TrainingOne.AmmanUnitTests
{
    [TestClass]
    public class AmmanDateValidatorTest
    {
        [TestMethod]
      public void AmmanDateValidatorTester()
      {
          AmmanDateValidator dateValidator = new AmmanDateValidator();
          Assert.IsTrue(dateValidator.CheckDate(2014, 04, 29));
          Assert.IsTrue(dateValidator.CheckDate(2014, 04, 30));
          //Assert.IsTrue(dateValidator.CheckDate(2014, 04, 31));
          //Assert.IsTrue(dateValidator.CheckDate(2014, 04, 32));

      }
    }
}
