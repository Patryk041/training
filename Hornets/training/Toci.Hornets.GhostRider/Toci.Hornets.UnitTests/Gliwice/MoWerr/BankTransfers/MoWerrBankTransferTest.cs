using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.MoWerr;

namespace Toci.Hornets.UnitTests.Gliwice.MoWerr.BankTransfers
{
    [TestClass]
    public class MoWerrBankTransferTest
    {
        [TestMethod]
        public void MoWerrBankTransferParserTest()
        {
            var bankTransferParser = new MoWerrBankTransferParser();

            var bankTransfers = bankTransferParser.GetBankTransfers();

            Assert.IsTrue(bankTransfers[0].IsTransferSuccessful);
            Assert.IsTrue(bankTransfers[1].IsTransferSuccessful);

            Assert.AreEqual(bankTransfers[0].DestinationBank, "mBank");
            Assert.AreEqual(bankTransfers[1].DestinationBank, "PKO");
        }
    }
}