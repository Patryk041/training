using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.DeeJay.TasksTrainingTwo;

namespace Toci.Hornets.UnitTests.Sieradz.DeeJay.TasksTrainingTwo
{
    [TestClass]
    public class DjStringManipulationsTest
    {
        private const string MyNick = "DeeJay";

        private DjStringManipulations _djStringManipulations;

        [TestInitialize]
        public void Init()
        {
            _djStringManipulations = new DjStringManipulations();
        }

        [TestMethod]
        public void GetNickTest()
        {
            var nick = _djStringManipulations.RunStringOperations("","").Nick;

            Assert.AreEqual(MyNick,nick);
        }

        [TestMethod]
        public void IsStringInStringTest()
        {
            var isStringInString = _djStringManipulations.RunStringOperations("beata", "at").IsStringInString;
            Assert.IsTrue(isStringInString);

            isStringInString = _djStringManipulations.RunStringOperations("beata", "ata").IsStringInString;
            Assert.IsTrue(isStringInString);

            isStringInString = _djStringManipulations.RunStringOperations("beata", "ea").IsStringInString;
            Assert.IsTrue(isStringInString);

            isStringInString = _djStringManipulations.RunStringOperations("beata", "ae").IsStringInString;
            Assert.IsFalse(isStringInString);

            isStringInString = _djStringManipulations.RunStringOperations("beata", "eb").IsStringInString;
            Assert.IsFalse(isStringInString);

            isStringInString = _djStringManipulations.RunStringOperations("beata", "aa").IsStringInString;
            Assert.IsFalse(isStringInString);
        }

        [TestMethod]
        public void IsStringElementsInStringTest()
        {
            var isStringElementsInString = _djStringManipulations.RunStringOperations("beata", "aat").IsStringElementsInString;
            Assert.IsTrue(isStringElementsInString);

            isStringElementsInString = _djStringManipulations.RunStringOperations("beata", "taae").IsStringElementsInString;
            Assert.IsTrue(isStringElementsInString);

            isStringElementsInString = _djStringManipulations.RunStringOperations("beata", "aea").IsStringElementsInString;
            Assert.IsTrue(isStringElementsInString);

            isStringElementsInString = _djStringManipulations.RunStringOperations("beata", "aaa").IsStringElementsInString;
            Assert.IsFalse(isStringElementsInString);

            isStringElementsInString = _djStringManipulations.RunStringOperations("beata", "taaa").IsStringElementsInString;
            Assert.IsFalse(isStringElementsInString);

            isStringElementsInString = _djStringManipulations.RunStringOperations("beata", "tta").IsStringElementsInString;
            Assert.IsFalse(isStringElementsInString);
        }

        [TestMethod]
        public void IsStringAnagramOfStringTest()
        {
            var isAnagram = _djStringManipulations.RunStringOperations("beata", "ataeb").IsAnagram;
            Assert.IsTrue(isAnagram);

            isAnagram = _djStringManipulations.RunStringOperations("beata", "aateb").IsAnagram;
            Assert.IsTrue(isAnagram);

            isAnagram = _djStringManipulations.RunStringOperations("beata", "tbaea").IsAnagram;
            Assert.IsTrue(isAnagram);

            isAnagram = _djStringManipulations.RunStringOperations("beata", "aaateb").IsAnagram;
            Assert.IsFalse(isAnagram);

            isAnagram = _djStringManipulations.RunStringOperations("beata", "fdwgdw").IsAnagram;
            Assert.IsFalse(isAnagram);
        }

        [TestMethod]
        public void IsSameStringInStringTest()
        {
            var result = _djStringManipulations.RunStringOperations("beata", "beata");

            Assert.IsTrue(result.IsAnagram);
            Assert.IsTrue(result.IsStringInString);
            Assert.IsTrue(result.IsStringElementsInString);
        }

        [TestMethod]
        public void IsAnagramElementsInStringTest()
        {
            var result = _djStringManipulations.RunStringOperations("beata", "aateb");

            Assert.IsTrue(result.IsAnagram);
            Assert.IsTrue(result.IsStringElementsInString);
        }

        [TestMethod]
        public void IsStringInStringElementsInStringTest()
        {
            var result = _djStringManipulations.RunStringOperations("beata", "ata");

            Assert.IsTrue(result.IsStringInString);
            Assert.IsTrue(result.IsStringElementsInString);
        }

        [TestMethod]
        public void IsLongerStringNotInStringTest()
        {
            var result = _djStringManipulations.RunStringOperations("beata", "beataaa");

            Assert.IsFalse(result.IsAnagram);
            Assert.IsFalse(result.IsStringInString);
            Assert.IsFalse(result.IsStringElementsInString);
        }

        [TestMethod]
        public void IsNullStringNotInStringTest()
        {
            var result = _djStringManipulations.RunStringOperations("beata", null);

            Assert.IsFalse(result.IsAnagram);
            Assert.IsFalse(result.IsStringInString);
            Assert.IsFalse(result.IsStringElementsInString);
        }

        [TestMethod]
        public void IsStringNotInNullStringTest()
        {
            var result = _djStringManipulations.RunStringOperations(null, "aba");

            Assert.IsFalse(result.IsAnagram);
            Assert.IsFalse(result.IsStringInString);
            Assert.IsFalse(result.IsStringElementsInString);
        }
    }
}
