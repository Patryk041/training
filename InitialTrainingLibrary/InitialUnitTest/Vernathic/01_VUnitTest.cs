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
        public void TestLeapYear()
        {
            Date date = new Date();
            date.year = 1600;

            Assert.IsTrue(LeapYear.IsLeapYear(date.year));
        }
    }
}
