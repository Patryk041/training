
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator;

namespace Toci.BeginnersTest.TrainingOne.CoouseyUnitTests
{
    [TestClass]
    public class CouseyTest
    {
        [TestMethod]
        public void DateValidatorTest()
        {
            CoouseyDateValidator couseyDateValidator = new CoouseyDateValidator();

            Assert.IsTrue(couseyDateValidator.CheckDate(2015, 4, 20));
            Assert.IsTrue(couseyDateValidator.CheckDate(5, 12, 10));
            Assert.IsTrue(couseyDateValidator.CheckDate(2016, 2, 29));
            Assert.IsTrue(couseyDateValidator.CheckDate(2000, 2, 29));

            Assert.IsFalse(couseyDateValidator.CheckDate(2000, 2, 30));
            Assert.IsFalse(couseyDateValidator.CheckDate(-10, 1, 1));
            Assert.IsFalse(couseyDateValidator.CheckDate(2000, 6, 31));
            Assert.IsFalse(couseyDateValidator.CheckDate(20000, 2, 30));
            Assert.IsFalse(couseyDateValidator.CheckDate(2000, 50, 50));
        }
    }
}
