using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.Pekao;

namespace Toci.Hornets.UnitTests.Sieradz.DeeJay.BankTransfers
{
    [TestClass]
    public class DjBankTransfersTest
    {
        private DjBankTransfersParser _djBankTransfersParser;
        private DjTransferHandle _djTransferHandle;

        [TestInitialize]
        public void Init()
        {
            _djBankTransfersParser = new DjBankTransfersParser();
            _djTransferHandle = new DjTransferHandle();
        }

        [TestMethod]
        public void GetBankTransfersTest()
        {
            var result = _djBankTransfersParser.GetBankTransfers();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TransferHandleTest()
        {
            var result = _djBankTransfersParser.GetBankTransfers();
            result.ForEach(x => _djTransferHandle.SendTransfer(x));

            Assert.IsTrue(result.Any(x => x.IsTransferSuccessful));
        }
    }
}
