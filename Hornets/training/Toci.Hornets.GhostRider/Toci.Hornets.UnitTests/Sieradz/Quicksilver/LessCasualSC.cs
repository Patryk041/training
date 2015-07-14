using Toci.Hornets.Sieradz.Quicksilver.UndergroundTasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.Hornets.UnitTests.Sieradz.Quicksilver
{
    [TestClass]
    public class LessCasualSC
    {
        [TestMethod]
        public void TestMethod1()
        {
            LessCasualStringComparator comparator = new LessCasualStringComparator();
            Assert.IsTrue(comparator.CompareTwoStrings("abc123xyz#$$", "xyz123cba!@#"));
            Assert.IsFalse(comparator.CompareTwoStrings("jnr$&y&23g&&&", "&yyFF&3&y&"));
            
        }
    }
}
