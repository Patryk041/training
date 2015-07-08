using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.Interfaces;
using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.MyPeselValidator;
using Toci.Hornets.UnitTests.Legnica.Patryk.Mock;

namespace Toci.Hornets.UnitTests.Legnica.Patryk
{
    [TestClass]
    public class PatrykPeselvalidatorTests
    {
        private FakeChecksumValidator fakeChecksumValidator = new FakeChecksumValidator();
        private FakePeselDateValidator fakePeselDateValidator = new FakePeselDateValidator();

        [TestMethod]
        public void ValidateDate_WhenDateInFuture()
        {
            PeselValidator validator = new PatrykPeselValidator(new PeselDateValidator(), fakeChecksumValidator);
            Assert.IsFalse(validator.IsPeselValid("16272199777"));
            Assert.IsTrue(validator.IsPeselValid("12261997779"));
        }

        [TestMethod]
        public void ValidateDate_WhenLeapYear()
        {
            PeselValidator validator = new PatrykPeselValidator(new PeselDateValidator(), fakeChecksumValidator);
            Assert.IsTrue(validator.IsPeselValid("04022955333"));
            Assert.IsFalse(validator.IsPeselValid("03022955333"));
        }

        [TestMethod]
        public void ValidateDate_WhenLastDayInMonth()
        {
            PeselValidator validator = new PatrykPeselValidator(new PeselDateValidator(), fakeChecksumValidator);
            Assert.IsTrue(validator.IsPeselValid("93063000377"));
            Assert.IsFalse(validator.IsPeselValid("93063100377"));
        }

        [TestMethod]
        public void ValidateChecksum_WhenEndByZero()
        {
            PeselValidator validator = new PatrykPeselValidator(fakePeselDateValidator, new ChecksumValidator());
            Assert.IsTrue(validator.IsPeselValid("49040501580"));
        }

        [TestMethod]
        public void ValidateChecksum_WhenEndGreaterThanZero()
        {
            PeselValidator validator = new PatrykPeselValidator(fakePeselDateValidator, new ChecksumValidator());
            Assert.IsTrue(validator.IsPeselValid("93060900377"));
            Assert.IsFalse(validator.IsPeselValid("44051401358"));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void IsPeselValid_WhenBadFormat_ThrowException()
        {
            PeselValidator validator = new PatrykPeselValidator();
            Assert.IsFalse(validator.IsPeselValid("93133200345"));
            Assert.IsFalse(validator.IsPeselValid("93002003455"));
            Assert.IsFalse(validator.IsPeselValid("93010003455"));
        }

        [TestMethod]
        public void IsPeselValid_WhenBadFormat()
        {
            PeselValidator validator = new PatrykPeselValidator();
            Assert.IsFalse(validator.IsPeselValid(null));
            Assert.IsFalse(validator.IsPeselValid("1aadf399%12"));
            Assert.IsFalse(validator.IsPeselValid("123"));
            Assert.IsFalse(validator.IsPeselValid("121011%&7%6"));
            Assert.IsFalse(validator.IsPeselValid("12345678901234"));
        }

        [TestMethod]
        public void IsPeselValid_WhenNoMock()
        {
            PeselValidator validator = new PatrykPeselValidator();
            Assert.IsTrue(validator.IsPeselValid("93060900377"));
            Assert.IsFalse(validator.IsPeselValid("44051401358"));
            Assert.IsFalse(validator.IsPeselValid("93063100377"));
            Assert.IsFalse(validator.IsPeselValid("00022955333"));
        }

        
    }
}