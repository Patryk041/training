using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam
{
    [TestClass]
    public class Undeground1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var StringCompare = new ExtraStringParser();
            Assert.IsTrue(StringCompare.CompareTwoStrings("a1aa111", "b2b3b54"));
            Assert.IsFalse(StringCompare.CompareTwoStrings("a1avcvca111", "b2b3b54"));

        }
    }
}
