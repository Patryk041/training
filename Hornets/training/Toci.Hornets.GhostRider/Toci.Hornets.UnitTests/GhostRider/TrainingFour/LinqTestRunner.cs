using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.TrainingFour.Linq;

namespace Toci.Hornets.UnitTests.GhostRider.TrainingFour
{
    [TestClass]
    public class LinqTestRunner
    {
        [TestMethod]
        public void TestLinqRunner()
        {
            LinqShowdown shd = new LinqShowdown();

            shd.RunLinqs();
        }
    }
}