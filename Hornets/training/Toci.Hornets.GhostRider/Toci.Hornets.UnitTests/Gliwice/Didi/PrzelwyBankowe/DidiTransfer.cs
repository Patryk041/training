using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe;

namespace Toci.Hornets.UnitTests.Gliwice.Didi.PrzelwyBankowe
{
    [TestClass]
    public class DidiTransfer
    {
        [TestMethod]
        public void TestMethod1()
        {
            DidiBankTransferParser transfer = new DidiBankTransferParser();

            transfer.GetBankTransfers();
        }
    }
}
