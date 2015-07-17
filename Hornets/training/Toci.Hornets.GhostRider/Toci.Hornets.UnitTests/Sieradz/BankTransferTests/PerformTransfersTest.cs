using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.SieradzBankTransferTask;

namespace Toci.Hornets.UnitTests.Sieradz.BankTransferTests
{
    [TestClass]
    public class PerformTransfersTest
    {
        [TestMethod]
        public void SieradzPerformTransfersTest()
        {
            var sieradzPerformTansfers = new SieradzPerformTransfers();

            sieradzPerformTansfers.TransferAll();
        }
    }
}