using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.SieradzBankTransferTask;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.Alior;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis.BankTransfers
{
    [TestClass]
    public class UCantTouchThisBankTransfersParserTests
    {
        [TestMethod]
        public void UCTT_BankTransfersParserTest()
        {
            var parser = new UCantTouchThisBankTransfersParser();
            var result = parser.GetBankTransfers();
            Assert.AreEqual(((SieradzBankTransfer) result[0]).TransferInfo.DestinationPersonName, "Grandek");
            Assert.AreEqual(((SieradzBankTransfer) result[4]).TransferInfo.TransferTitle, "Niebiezpieczne sprzety");
        }
    }
}