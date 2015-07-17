using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank;

namespace Toci.Hornets.UnitTests.Rzeszow.Terry.TerryBankTest
{
    [TestClass]
    public class TerryBankTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var tbHandle = new TerryBankTransferHandle();
            var transfer = new TerryBankTransfer("500", "1234", "Zapart", "5678", "Wysocki", "Allior",
                "TerryBank", "siszarp", "y");

            tbHandle.TerrySendTransfers(transfer);
            var test = new TerryBankTransfersParser();

            var lista =  test.GetBankTransfers();

           
        }
    }
}
