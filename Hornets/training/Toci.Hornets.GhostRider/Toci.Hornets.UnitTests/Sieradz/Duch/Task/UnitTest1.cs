using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.Duch.Traning;

namespace Toci.Hornets.UnitTests.Sieradz.Duch.Task
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DuchGenList<int> aaa = new DuchGenList<int>();
            aaa.Add(50);
            aaa.Remove(50);
            aaa.Add(5);
            var res = aaa;

        }
    }
}
