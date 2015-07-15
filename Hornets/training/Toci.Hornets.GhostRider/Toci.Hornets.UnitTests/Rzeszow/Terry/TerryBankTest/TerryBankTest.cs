using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank;

namespace Toci.Hornets.UnitTests.Rzeszow.Terry.TerryBankTest
{
    [TestClass]
    public class TerryBankTest
    {
        [TestMethod]
        public void TestMethod()
        {
            TerryBankTransferHandle tbHandle = new TerryBankTransferHandle();
            var transfer = new BankTransfer()
            {
                DestinationBank = "mBank",
                SourceBank = "TerryBank",
                IsTransferSuccessful = true

            };

            
            
        }
    }
}
