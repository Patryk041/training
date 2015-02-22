using System;
using System.Text;
using System.Collections.Generic;
using InitialTrainingLibrary.Sito._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.Sito
{
    /// <summary>
    /// Summary description for SitoTest
    /// </summary>
    [TestClass]
    public class SitoTest
    {

        [TestMethod]
        public void SitoTestMethod()
        {

           
            InitialTrainingLibrary.Sito._1.DateValidator validator = new DateValidator();

            Assert.IsFalse(validator.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator.DateValidate(2014, 04, 31));
            Assert.IsFalse(validator.DateValidate(2015, 02, 29));
            Assert.IsFalse(validator.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator.DateValidate(2014, 12, 30));
            Assert.IsFalse(validator.DateValidate(2014, 09, 32));
            Assert.IsTrue(validator.DateValidate(2014, 06, 10));
            Assert.IsTrue(validator.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator.DateValidate(2014, 02, 29));
            Assert.IsTrue(validator.DateValidate(2014, 02, 28));
            Assert.IsFalse(validator.DateValidate(2014, 04, 31));
            Assert.IsFalse(validator.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator.DateValidate(2014, 04, 31));
            Assert.IsFalse(validator.DateValidate(2015, 02, 29));
        }
    }
}
