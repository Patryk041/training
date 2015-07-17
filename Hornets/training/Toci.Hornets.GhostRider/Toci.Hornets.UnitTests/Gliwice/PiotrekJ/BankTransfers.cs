using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.PiotrekJ;

namespace Toci.Hornets.UnitTests.Gliwice.PiotrekJ
{
    public class BankTransfers
    {
        [TestClass]
        public class PiotrekJBanki
        {
            [TestMethod]
            public void TestMethod1()
            {
                PiotrekJBankTransferParser transfer = new PiotrekJBankTransferParser();
                transfer.GetBankTransfers();
            }
        } 
    }
}