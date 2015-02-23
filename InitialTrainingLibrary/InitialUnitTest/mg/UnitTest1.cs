using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialTrainingLibrary.mg.DateValidator;

namespace InitialUnitTest.mg
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateValidator validator = new DateValidator();
            Assert.IsTrue(validator.DateValidate(2009, 12, 30));
            Assert.IsTrue(validator.DateValidate(2015, 02, 28));
            Assert.IsTrue(validator.DateValidate(2015, 08, 01));
            Assert.IsTrue(validator.DateValidate(2015, 07, 31));

            Assert.IsFalse(validator.DateValidate(-1, 12, 30));
            Assert.IsFalse(validator.DateValidate(2014, 02, 30));
            Assert.IsFalse(validator.DateValidate(2010, 04, 31));
        }
    }
}
