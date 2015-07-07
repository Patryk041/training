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
            StringManipulator.RunStringOperations("abcd", "dccccba");
        }
    }
}
