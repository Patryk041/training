using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Hipek;

namespace Toci.Hornets.UnitTests.Gliwice.Hipek.BankTransferTest
{
    [TestClass]
    public class HipekBankTransferTest
    {
        [TestMethod]
        public void HipekBankTransferTestMethod()
        {
            HipekBankTransferParser hipekbankTransferParser = new HipekBankTransferParser();
            List<BankTransfer> transferList = hipekbankTransferParser.GetBankTransfers();
        }
    }
}
