using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.TypowyAdam.TrainingTwoTasks.StringManipulator;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam
{
    [TestClass]
    public class TypowyAdamStringManipulatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            TypowyAdamStringManipulator StringManipulator = new TypowyAdamStringManipulator();
            var result = StringManipulator.RunStringOperations("abcd", "dcba");
            Assert.IsTrue(result.IsAnagram);
            Assert.IsTrue(result.IsStringElementsInString);
            Assert.IsFalse(result.IsStringInString);
        }
    }
}
