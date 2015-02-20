using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.frogie;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.frogie
{
    [TestClass]
    public class FrogieTest
    {
        [TestMethod]
        public void TestDate()
        {
            FrogieDateValidator validator = new FrogieDateValidator();
            
            Assert.IsFalse(validator.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator.DateValidate(2014, 04, 31));

        }
    }
}
