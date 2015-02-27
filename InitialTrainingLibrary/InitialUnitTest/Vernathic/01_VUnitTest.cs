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
            Date date = new Date(1693,2,30);

            DateValidator validator = new DateValidator();
            Assert.IsTrue(validator.DateValidate(date.year, date.month, date.day));

            Assert.IsFalse(LeapYear.IsLeapYear(date.year));
            //Assert.AreEqual(Month.GetMonthLenght(date.year, date.month), 30);
        }

        [TestMethod]
        public void TestChess()
        {

        }
    }
}
