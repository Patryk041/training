using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.dysq.DateValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.dysq
{
    [TestClass]
    public class dysqTest
    {
        [TestMethod]
        public void TestMyDate()
        {
            MyDate validator = new MyDate();

            Assert.IsFalse(validator.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator.DateValidate(2014, 12, 30));
            Assert.IsFalse(validator.DateValidate(2014, 09, 32));
            Assert.IsTrue(validator.DateValidate(2014, 06, 10));
            Assert.IsTrue(validator.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator.DateValidate(2014, 02, 29));
            Assert.IsTrue(validator.DateValidate(2014, 02, 28));
            Assert.IsFalse(validator.DateValidate(2014, 04, 31));
        }

    }
}
