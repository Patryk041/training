using System;
using System.Security.Cryptography.X509Certificates;
using InitialTrainingLibrary;
using InitialTrainingLibrary.Domi.Validator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.Domi.Validator
{
    [TestClass]
    public class DomiUnitTestValidator
    {

        [TestMethod]
        public void TestMethod1()
        {
            DataValidator dataTest = new DataValidator();
            Assert.IsTrue(dataTest.DateValidate(1993, 3, 13));
            Assert.IsFalse(dataTest.DateValidate(2012, 2, 30));
            Assert.IsFalse(dataTest.DateValidate(1993, 3, 50));
            Assert.IsTrue(dataTest.DateValidate(2012, 2, 29));
            Assert.IsFalse(dataTest.DateValidate(1993, 13, 10));
        }
    }
}
