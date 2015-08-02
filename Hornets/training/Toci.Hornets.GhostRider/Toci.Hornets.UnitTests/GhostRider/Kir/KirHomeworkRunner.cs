using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.UnitTests.GhostRider.Abstraction;

namespace Toci.Hornets.UnitTests.GhostRider.Kir
{
    [TestClass]
    public class KirHomeworkRunner : TestBase
    {
        [TestMethod]
        public void RunKirHomeworks()
        {
            var tranfersPerformer = GetDerivingTypes<PerformTransfers>();

            foreach (var item in tranfersPerformer)
            {
                item.TransferAll();
            }
        }
    }
}