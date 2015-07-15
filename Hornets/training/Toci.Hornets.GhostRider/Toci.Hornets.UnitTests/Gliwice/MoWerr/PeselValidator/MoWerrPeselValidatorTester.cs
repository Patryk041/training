using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.MoWerr.PeselValidator;

namespace Toci.Hornets.UnitTests.Gliwice.MoWerr.PeselValidator
{
    [TestClass]
    public class MoWerrPeselValidatorTester : MoWerrPeselValidator
    {
        private readonly string[] _validPesels =
        {
            "95012605637",
            "54012262051",
            "67081685582"
        };

        private readonly string[] _invalidPesels =
        {
            "44051401358",
            "07008807749"
        };

        [TestMethod]
        public void MoWerrCutOffDateTest()
        {
            var date = CutOffDate(_validPesels[0]);

            Assert.AreEqual(date, "950126");
        }

        [TestMethod]
        public void MoWerrCheckSumTest()
        {
            foreach (var validPesel in _validPesels)
            {
                Assert.IsTrue(Checksum(validPesel));
            }
            foreach (var invalidPesel in _invalidPesels)
            {
                Assert.IsFalse(Checksum(invalidPesel));
            }
        }

        [TestMethod]
        public void MoWerrIsPeselValidTest()
        {
            foreach (var validPesel in _validPesels)
            {
                Assert.IsTrue(IsPeselValid(validPesel));
            }
            foreach (var invalidPesel in _invalidPesels)
            {
                Assert.IsFalse(IsPeselValid(invalidPesel));
            }
        }

        [TestMethod]
        public void MoWerrDateValidationTest()
        {
            Assert.IsTrue(ValidateDate(95,01,26));
            Assert.IsTrue(ValidateDate(02,27,14));
            Assert.IsFalse(ValidateDate(95,41,12));
            Assert.IsTrue(ValidateDate(04,22,29));
            Assert.IsFalse(ValidateDate(00,22,30));
            Assert.IsFalse(ValidateDate(01,22,29));
            Assert.IsFalse(ValidateDate(95,04,31));
            Assert.IsTrue(ValidateDate(02,23,31));
            Assert.IsTrue(ValidateDate(95,27,31));
            Assert.IsTrue(ValidateDate(95,27,31));
            Assert.IsFalse(ValidateDate(94,9,31));
        }

        [TestMethod]
        public void MoWerrDataSeparatorTest()
        {
            var date = CutOffDate(_validPesels[0]);

            int year, month, day;

            SeparateDate(date, out year, out month, out day);

            Assert.AreEqual(95, year);
            Assert.AreEqual(26, day);
            Assert.AreEqual(1, month);
        }
    }
}
