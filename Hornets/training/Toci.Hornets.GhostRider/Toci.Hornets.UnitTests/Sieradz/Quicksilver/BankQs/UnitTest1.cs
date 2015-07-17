using System;
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
            test2.GetBankTransfers();
        }
    }
}
