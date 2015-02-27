using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.DateTimeValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.Chmura
{
    [TestClass]
    public class SprawdzTo
    {
        [TestMethod]
        public void ChmuraDateTest()
        {
            DateValidator dataTest = new DateValidator();
            Assert.IsTrue(dataTest.DateValidate(1993, 2, 13));
            Assert.IsFalse(dataTest.DateValidate(1993, 2, 29));
            Assert.IsFalse(dataTest.DateValidate(2000, 13, 32));
        }
    }
}
