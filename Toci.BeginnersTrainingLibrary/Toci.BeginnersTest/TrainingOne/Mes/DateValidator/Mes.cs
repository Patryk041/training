using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Mes.DateValidator;

namespace Toci.BeginnersTest.TrainingOne.Mes.DateValidator
{
    [TestClass]
    public class Mes
    {
        [TestMethod]
        public void mesTestMethod()
        {
            Assert.IsTrue(YearValidator.IsLeapYear(2000));
            Assert.IsTrue(YearValidator.IsLeapYear(2004));
            Assert.IsTrue(YearValidator.IsLeapYear(2008));
            Assert.IsFalse(YearValidator.IsLeapYear(2001));
            Assert.IsFalse(YearValidator.IsLeapYear(2006));

            Assert.IsTrue(MonthValidator.ValidateMonth(7));
            Assert.IsTrue(MonthValidator.ValidateMonth(12));
            Assert.IsFalse(MonthValidator.ValidateMonth(14));
            Assert.IsFalse(MonthValidator.ValidateMonth(0));

            MesDateValidator mv = new MesDateValidator();
            Assert.IsTrue(mv.CheckDate(12, 2, 2013));
            Assert.IsTrue(mv.CheckDate(29, 2, 2000));
            Assert.IsFalse(mv.CheckDate(29, 2, 2001));
            Assert.IsFalse(mv.CheckDate(35, 2, 2001));
        }
    }
}
