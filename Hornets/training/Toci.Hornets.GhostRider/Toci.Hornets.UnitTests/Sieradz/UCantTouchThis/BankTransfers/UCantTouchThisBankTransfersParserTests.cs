using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.Alior;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis.BankTransfers
{
    [TestClass]
    public class UCantTouchThisBankTransfersParserTests
    {
        [TestMethod]
        public void UCTTBankTransfersParserTest()
        {
            var parser = new UCantTouchThisBankTransfersParser();
            parser.GetBankTransfers();
        }
    }
}