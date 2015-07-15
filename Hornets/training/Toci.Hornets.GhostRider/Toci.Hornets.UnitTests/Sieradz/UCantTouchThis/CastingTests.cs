using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.CastingExamples;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{
    [TestClass]
    public class CastingTests
    {
        [TestMethod]
        public void UCTT_CastingTestOne()
        {
            var castingExample = new CastingExampleOne();
            Assert.AreEqual(castingExample.ExampleOne(), 12.12);
        }
    }
}
