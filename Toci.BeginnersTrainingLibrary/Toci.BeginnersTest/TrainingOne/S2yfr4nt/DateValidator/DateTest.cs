using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.DateValidator;

namespace Toci.BeginnersTest.TrainingOne.S2yfr4nt.DateValidator
{
    [TestClass]
    public class DateTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            S2yfr4ntDateValidator testDate = new S2yfr4ntDateValidator();
            Assert.IsFalse(testDate.CheckDate(-2015, 2, 27));
            Assert.IsFalse(testDate.CheckDate(2013, 2, 28));
            Assert.IsFalse(testDate.CheckDate(2012, 2, 30));
            Assert.IsTrue(testDate.CheckDate(1994, 12, 31));
            Assert.IsTrue(testDate.CheckDate(1350, 2, 27));
            Assert.IsFalse(testDate.CheckDate(1170, 13, 20));
            Assert.IsTrue(testDate.CheckDate(1110, 11, 20));
        }
    }
}
