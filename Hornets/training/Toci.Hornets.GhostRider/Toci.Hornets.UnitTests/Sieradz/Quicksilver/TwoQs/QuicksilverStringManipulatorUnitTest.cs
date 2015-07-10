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
            comparator.RunStringOperations("abcd", "dccccba");
        }
    }
}
