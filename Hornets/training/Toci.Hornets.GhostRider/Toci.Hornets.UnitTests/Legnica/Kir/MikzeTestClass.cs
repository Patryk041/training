using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.BankTransfersParsers;

namespace Toci.Hornets.UnitTests.Legnica.Kir
{
    [TestClass]
    public class MikzeTestClass
    {
        [TestMethod]
        public void Metoda()
        {
            BzwbkBankTransfrsParser transfer = new BzwbkBankTransfrsParser();
            var bankTransfers = transfer.GetBankTransfers();

        }
    }
}