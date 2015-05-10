
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.coousey.TextUtils;

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

        [TestMethod]
        public void IsPalindromTest()
        {
            PalindromValidator palindromValidator = new PalindromValidator();

            Assert.IsTrue(palindromValidator.ValidateExpresion("ala", null));
            Assert.IsFalse(palindromValidator.ValidateExpresion("aal", null));
        }

        [TestMethod]
        public void IsAnagramTest()
        {
            AnagramValidator anagramValidator = new AnagramValidator();

            Assert.IsTrue(anagramValidator.ValidateExpresion("ala", "aal"));
            Assert.IsFalse(anagramValidator.ValidateExpresion("ala", "all"));
        }

        [TestMethod]
        public void IsWildCardTest()
        {
            WildCardValidator wildCardValidator = new WildCardValidator();

            Assert.IsTrue(wildCardValidator.ValidateExpresion("blaa", "bla"));
            Assert.IsFalse(wildCardValidator.ValidateExpresion("blaa", "ala"));
        }

        [TestMethod]
        public void ExpresionValidatorTest()
        {
            CoouseyTextUtils coouseyTextUtils = new CoouseyTextUtils(new []{"ala","bbo","obb","ci","ca","cu"});
          
            Assert.AreEqual(1, coouseyTextUtils.GetPalindromsSet().Length);
            Assert.AreEqual(2, coouseyTextUtils.GetAnagramsSet("bob").Length);
            Assert.AreEqual(3, coouseyTextUtils.GetWildCardSet("c").Length);
        }
    }
}
