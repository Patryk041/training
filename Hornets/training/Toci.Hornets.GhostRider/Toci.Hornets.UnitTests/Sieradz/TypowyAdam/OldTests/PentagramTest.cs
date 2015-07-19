using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;
namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam
{
    [TestClass]
    public class PentagramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pentagram pentagram = new Pentagram();
            pentagram.VisitVertices();
        }
    }
}
