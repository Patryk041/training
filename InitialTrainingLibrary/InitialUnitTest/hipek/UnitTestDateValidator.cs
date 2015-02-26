using System;
using InitialTrainingLibrary.hipek._1.DateValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.hipek
{
    [TestClass]
    public class UnitTestDateValidator
    {
        [TestMethod]
        public void TestMethodDateValidator()
        {
            DateValidator test = new DateValidator();

            Assert.IsTrue(test.DateValidate(2014, 01, 15));
            Assert.IsFalse(test.DateValidate(2014, 01, 40));
            Assert.IsFalse(test.DateValidate(2014, 04, 31));
            Assert.IsTrue(test.DateValidate(2014, 06, 30));
            Assert.IsTrue(test.DateValidate(2012, 02, 29)); //jest przestepny
            Assert.IsFalse(test.DateValidate(2014, 02, 29)); //nie jest przestepny
            Assert.IsTrue(test.DateValidate(2014, 02, 28)); //nie jest przestepny
            Assert.IsFalse(test.DateValidate(2014, 13, 28));
            Assert.IsFalse(test.DateValidate(00, 00, 00));
            Assert.IsFalse(test.DateValidate(-2, 05, 12));
        }
    }
}
