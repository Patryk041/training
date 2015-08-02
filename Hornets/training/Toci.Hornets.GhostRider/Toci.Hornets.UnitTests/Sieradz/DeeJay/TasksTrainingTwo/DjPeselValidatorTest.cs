using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.DeeJay.TasksTrainingTwo;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;

namespace Toci.Hornets.UnitTests.Sieradz.DeeJay.TasksTrainingTwo
{
    [TestClass]
    public class DjPeselValidatorTest
    {
        private const string MyNick = "DeeJay";

        private DjPeselValidator _djPeselValidator;

        [TestInitialize]
        public void Init()
        {
            _djPeselValidator = new DjPeselValidator();
        }

        [TestMethod]
        public void GetNickTest()
        {
            var nick = _djPeselValidator.GetNick();

            Assert.AreEqual(MyNick, nick);
        }

        [TestMethod]
        public void IsPeselValidTest()
        {
            var isValid = _djPeselValidator.IsPeselValid("74021834018");
            Assert.IsTrue(isValid);

            isValid = _djPeselValidator.IsPeselValid("74021834025");
            Assert.IsTrue(isValid);

            isValid = _djPeselValidator.IsPeselValid("74021834001");
            Assert.IsTrue(isValid);

            isValid = _djPeselValidator.IsPeselValid("74021834012");
            Assert.IsFalse(isValid);

            isValid = _djPeselValidator.IsPeselValid("49040501580");
            Assert.IsTrue(isValid);

            isValid = _djPeselValidator.IsPeselValid("46040501580");
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsCharPeselNotValidTest()
        {
            var isValid = _djPeselValidator.IsPeselValid("7402183401A");
            Assert.IsFalse(isValid);

            isValid = _djPeselValidator.IsPeselValid("Z4021834025");
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsTooShortPeselNotValidTest()
        {
            var isValid = _djPeselValidator.IsPeselValid("7402183401");
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsTooLongPeselNotValidTest()
        {
            var isValid = _djPeselValidator.IsPeselValid("740218340123");
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsEmptyPeselNotValidTest()
        {
            var isValid = _djPeselValidator.IsPeselValid("");
            Assert.IsFalse(isValid);

            isValid = _djPeselValidator.IsPeselValid(null);
            Assert.IsFalse(isValid);
        }
    }
}
