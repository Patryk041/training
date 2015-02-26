using InitialTrainingLibrary.Interfaces;
using InitialTrainingLibrary.RS.DateValidator.Complex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.RS
{
    [TestClass]
    public class DateValidatorTests
    {
        class Date
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        }

        [TestMethod]
        public void Do_Validator_Valid_Years_Properly()
        {
            Date validYear = new Date
            {
                Day = 1,
                Month = 1,
                Year = 1960
            };

            Date invalidYear = new Date
            {
                Day = 1,
                Month = 1,
                Year = -100
            };

            IDateValidator target = new DateValidator();

            bool validDateResult = target.DateValidate(validYear.Year, validYear.Month, validYear.Day);
            bool invalidDateResult = target.DateValidate(invalidYear.Year, invalidYear.Month, invalidYear.Day);

            Assert.IsTrue(validDateResult);
            Assert.IsFalse(invalidDateResult);
        }

        [TestMethod]
        public void Do_Validator_Valid_Months_Properly()
        {
            Date validMonth = new Date
            {
                Day = 1,
                Month = 3,
                Year = 1960
            };

            Date invalidMonth1 = new Date
            {
                Day = 1,
                Month = -1,
                Year = 1960
            };

            Date invalidMonth2 = new Date
            {
                Day = 1,
                Month = 14,
                Year = 1960
            };

            IDateValidator target = new DateValidator();

            bool validDateResult = target.DateValidate(validMonth.Year, validMonth.Month, validMonth.Day);
            bool invalidDateResult = target.DateValidate(invalidMonth1.Year, invalidMonth1.Month, invalidMonth1.Day);
            bool invalidDateResult2 = target.DateValidate(invalidMonth2.Year, invalidMonth2.Month, invalidMonth2.Day);

            Assert.IsTrue(validDateResult);
            Assert.IsFalse(invalidDateResult);
            Assert.IsFalse(invalidDateResult2);
        }

        [TestMethod]
        public void Do_Validator_Valid_Days_Properly()
        {
            Date validDayMarz = new Date
            {
                Day = 31,
                Month = 3,
                Year = 1960
            };

            Date validDayApril = new Date
            {
                Day = 30,
                Month = 4,
                Year = 1960
            };

            Date validDayFeb = new Date
            {
                Day = 28,
                Month = 2,
                Year = 2003
            };

            Date validDayFebLeapYear = new Date
            {
                Day = 28,
                Month = 2,
                Year = 2000
            };

            Date invalidDayMarz = new Date
            {
                Day = 32,
                Month = 3,
                Year = 1960
            };

            Date invalidDayApril = new Date
            {
                Day = 31,
                Month = 4,
                Year = 1960
            };

            Date invalidDayFeb = new Date
            {
                Day = 29,
                Month = 2,
                Year = 2003
            };

            Date invalidDayFebLeapYear = new Date
            {
                Day = 30,
                Month = 2,
                Year = 2000
            };

            IDateValidator target = new DateValidator();

            bool validDateMarzResult = target.DateValidate(validDayMarz.Year, validDayMarz.Month, validDayMarz.Day);
            bool validDateAprilResult = target.DateValidate(validDayApril.Year, validDayApril.Month, validDayApril.Day);
            bool validDateFebResult = target.DateValidate(validDayFeb.Year, validDayFeb.Month, validDayFeb.Day);
            bool validDateFebLeapYearResult = target.DateValidate(validDayFebLeapYear.Year, validDayFebLeapYear.Month, validDayFebLeapYear.Day);

            bool invalidDateMarzResult = target.DateValidate(invalidDayMarz.Year, invalidDayMarz.Month, invalidDayMarz.Day);
            bool invalidDateAprilResult = target.DateValidate(invalidDayApril.Year, invalidDayApril.Month, invalidDayApril.Day);
            bool invalidDateFebResult = target.DateValidate(invalidDayFeb.Year, invalidDayFeb.Month, invalidDayFeb.Day);
            bool invalidDateFebLeapYearResult = target.DateValidate(invalidDayFebLeapYear.Year, invalidDayFebLeapYear.Month, invalidDayFebLeapYear.Day);

            Assert.IsTrue(validDateMarzResult);
            Assert.IsTrue(validDateAprilResult);
            Assert.IsTrue(validDateFebResult);
            Assert.IsTrue(validDateFebLeapYearResult);

            Assert.IsFalse(invalidDateMarzResult);
            Assert.IsFalse(invalidDateAprilResult);
            Assert.IsFalse(invalidDateFebResult);
            Assert.IsFalse(invalidDateFebLeapYearResult);
        }
    }
}
