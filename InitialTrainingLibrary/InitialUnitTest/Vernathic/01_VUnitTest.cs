using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialTrainingLibrary.Vernathic._01_DateValidator;

namespace InitialUnitTest.Vernathic
{
    [TestClass]
    public class VernathicUnitTest
    {
        [TestMethod]
        public void TestDateValidator()
        {
            VDate date = new VDate(1693,2,30);

            VDateValidator validator = new VDateValidator();
            Assert.IsTrue(validator.DateValidate(date.year, date.month, date.day));

            Assert.IsFalse(VLeapYear.IsLeapYear(date.year));
            Assert.AreEqual(VMonth.GetMonthLenght(date.year, date.month), 30);
        }

        [TestMethod]
        public void TestChess()
        {

        }
    }
}
