using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Terry.TrainingTwo.StringManipulation;

namespace Toci.Hornets.UnitTests.Rzeszow.Terry.StringManipulatorTest
{
    [TestClass]
    public class TerryStringManipulatorTest
    {
        [TestMethod]

        public void StringManipulatorTest()
        {
            var stringManipulator = new TerryStringManipulator();
            stringManipulator.RunStringOperations("beata", "taa");
        }
    }
}