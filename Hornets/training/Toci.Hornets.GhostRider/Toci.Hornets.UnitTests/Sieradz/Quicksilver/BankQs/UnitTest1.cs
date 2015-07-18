using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.BPH;

namespace Toci.Hornets.UnitTests.Sieradz.Quicksilver.BankQs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test2 = new QuicksilverBankTransfersParser();
            var cos = test2.GetBankTransfers();

            var test3 = new QuicksilverTransferHandle();
            test3.SendTransfer(cos.First());

        }
    }
}
