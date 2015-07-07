using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Rzeszow.Terry.TrainingTwo.StringManipulation;

namespace Toci.Hornets.UnitTests.Rzeszow.Terry.StringManipulatorTest
{
    [TestClass]
    public class TerryStringManipulatorTest
    {
        [TestMethod]

        public void StringManipulatorTest()
        {
            TerryStringManipulator stringManipulator = new TerryStringManipulator();
            
          var test = stringManipulator.RunStringOperations("beata", "baosdhf");

            
        }
    }
}