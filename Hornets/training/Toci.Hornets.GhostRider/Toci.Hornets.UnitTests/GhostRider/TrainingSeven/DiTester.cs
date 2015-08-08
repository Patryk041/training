using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.Kir.BankLoggingMechanism;
using Toci.Hornets.GhostRider.TrainingSeven.Di;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.TransferHandles;
using Toci.Hornets.UnitTests.GhostRider.TrainingSeven.Di;
using Toci.Hornets.Wroclaw.ProjectElixir;

namespace Toci.Hornets.UnitTests.GhostRider.TrainingSeven
{
    [TestClass]
    public class DiTester
    {
        [TestMethod]
        public void DoREslove()
        {
            DependencyResolver resolver = new DependencyResolver();

            //var nietak = new TransferMoney(new IngTransferHandle(), new IngLogTransfer());

            var result = resolver.Resolve<TransferMoney>();
            result.DoTransfer(new BankTransferWroclaw());
        }
    }
}