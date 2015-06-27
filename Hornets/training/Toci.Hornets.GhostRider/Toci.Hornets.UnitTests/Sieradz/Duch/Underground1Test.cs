using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets;
using Toci.Hornets.Sieradz.Duch;

namespace Toci.Hornets.UnitTests.Duch
{
    [TestClass]
    public class Underground1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var comp = new DuchStringComparator();
            Assert.IsTrue(comp.CompareTwoStrings("aaa","bbb"));
        }
    }
}
