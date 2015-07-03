using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.Quicksilver.UndergroundTasks;

namespace Toci.Hornets.UnitTests.Sieradz.Quicksilver
{
    [TestClass]
    public class MyFirstUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           CasualStringComparator comparator = new CasualStringComparator();
           //comparator.CompareTwoStrings("aaaa", "bbb");
           Assert.IsTrue(comparator.CompareTwoStrings("a123b", "ab"));
            //Debug.WriteLine("Patrz jak wypisuje!");
            Assert.IsFalse(comparator.CompareTwoStrings("a", "1 23werdfscvdfdf"));
            
        }
    }
}
