using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.gipson.GipsonKIR;

namespace Toci.Hornets.UnitTests.Bytom.gipson.BankTransfer
{
    [TestClass]
    public class TransferCreationTest
    {
        [TestMethod]
        public void TestTransferCreation()
        {
            var gbtp = new GipsonBankTransferParser();
            var lista = gbtp.GetBankTransfers();
        }
    }
}