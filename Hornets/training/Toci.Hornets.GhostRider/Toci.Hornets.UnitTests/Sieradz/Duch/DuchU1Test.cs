using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.Sieradz.Duch;
using Toci.Hornets.Sieradz.Duch.Homework_1;

namespace Toci.Hornets.UnitTests.Sieradz.Duch
{
    [TestClass]
    public class DuchU1Test 
    {
        [TestMethod]
        public void TestMethod1()
        {
            
          
            var comp = new DuchStringComparator();
            Assert.IsTrue(comp.CompareTwoStrings("aaa","bbb"));
            Assert.IsFalse(comp.CompareTwoStrings("aaa", "bbb"));
        }

        [TestMethod]
        public void TelephoneTest()
        {
           // var dd = new DuchTele();

            //var xxx = dd.Abc(1);

        }

    }
}
