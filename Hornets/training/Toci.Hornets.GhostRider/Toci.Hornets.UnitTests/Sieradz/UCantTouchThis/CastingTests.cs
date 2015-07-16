using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.CastingExamples;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{
    [TestClass]
    public class CastingTests
    {
        readonly CastingExampleOne _castingExample = new CastingExampleOne();

        [TestMethod]
        public void UCTT_CastingTestOne()
        {
            Assert.AreEqual(_castingExample.ExampleOne(), 12.12);
        }

        [TestMethod]
        public void UCTT_CastingTestTwo()
        {
            var tmp = _castingExample.ExampleTwo();
            Assert.AreEqual(tmp.TransferInfo.Amount, "mnóstwo");
        }
    }
}
