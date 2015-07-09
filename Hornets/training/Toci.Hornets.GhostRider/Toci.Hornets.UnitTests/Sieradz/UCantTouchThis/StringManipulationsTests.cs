using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis;
using Toci.Hornets.Sieradz.UCantTouchThis.TasksTrainingTwo;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{
    [TestClass]
    public class StringManipulationsTests
    {
        private const string subject = "beata";

        private readonly List<string> _trueForIsStringInString = new List<string>
        { "at", "ata", "ta", "ea" };

        private readonly List<string> _falseForIsStringInString = new List<string>
        { "ae", "eb", "aa" };

        private readonly List<string> _trueForIsStringElementsInString = new List<string>
        { "aat", "taae", "aea" };

        private readonly List<string> _falseForIsStringElementsInString = new List<string>
        { "aaa", "taaa", "tta", "aee" };

        private readonly List<string> _trueForIsStringAnagramOfString = new List<string>
        { "ataeb","aateb","tbaea" };

        private readonly List<string> _falseForIsStringAnagramOfString = new List<string>
        { "aaateb", "fdwgdw" };

        private readonly UCantTouchThisStringManipulations _manipulator = new UCantTouchThisStringManipulations();

        [TestMethod]
        public void UCTT_StringManipulationsTest()
        {

            TestElement(_trueForIsStringInString, "IsStringInString", true);
            TestElement(_falseForIsStringInString, "IsStringInString", false);
            TestElement(_trueForIsStringElementsInString, "IsStringElementsInString", true);
            TestElement(_falseForIsStringElementsInString, "IsStringElementsInString", false);
            TestElement(_trueForIsStringAnagramOfString, "IsAnagram", true);
            TestElement(_falseForIsStringAnagramOfString, "IsAnagram", false);
        }

        private void TestElement(List<string> seekList, string propertyName, bool condition)
        {
            foreach (var item in seekList)
            {
                Assert.AreEqual(condition, _manipulator.RunStringOperations(subject,item)
                    .GetPropertyValue(propertyName));
            }
        }
    }
}