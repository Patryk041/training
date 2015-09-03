using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.Quicksilver.TasksTrainingTwoQs;

namespace Toci.Hornets.UnitTests.Sieradz.Quicksilver.TwoQs
{
    [TestClass]
    public class QuicksilverStringManipulatorUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            QuicksilverStringManipulator comparator = new QuicksilverStringManipulator();
            var results = comparator.RunStringOperations("abcd", "dccccba");
            Assert.IsTrue(results.IsStringElementsInString);
            Assert.IsFalse(results.IsAnagram);
            //Assert.AreEqual(results.IsAnagram && results.IsStringElementsInString, true);
            results = comparator.RunStringOperations("alamakota", "kot");
            
        }
    }
}
