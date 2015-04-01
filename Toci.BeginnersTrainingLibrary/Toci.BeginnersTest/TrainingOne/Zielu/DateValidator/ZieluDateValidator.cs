using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator;

namespace Toci.BeginnersTest.TrainingOne.Zielu.DateValidator
{
    [TestClass]
    public class ZieluDateValidation
    {
        [TestMethod]
        public void Test()
        {
            ZieluDateValidator blah = new ZieluDateValidator();
            Assert.IsFalse(blah.CheckDate(1998,17,14));
            Assert.IsTrue(blah.CheckDate(2004,2,29));
        }
    }
}
