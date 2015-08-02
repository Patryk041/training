using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.TrainingThree;
using Toci.Hornets.GhostRider.TrainingThree.Chor;

namespace Toci.Hornets.UnitTests.GhostRider.GeneralTests
{
    [TestClass]
    public class DebugingTesting 
    {
        [TestMethod]
        public void ALotOfDebuging()
        {
            BenchingOverriding bo = new BenchingOverriding();

            //bo.OverloadingExamplesTesting();
            bo.TestItAll();
        }

        [TestMethod]
        public void TestRefs()
        {
            OperacjeRefWar operacje = new OperacjeRefWar();

            operacje.AleZeMnieDebil();
        }
    }
}