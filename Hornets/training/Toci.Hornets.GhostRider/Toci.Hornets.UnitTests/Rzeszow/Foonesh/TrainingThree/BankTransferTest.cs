using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Foonesh.TrainingThree;

namespace Toci.Hornets.UnitTests.Rzeszow.Foonesh.TrainingThree
{
    [TestClass]
    public class BankTransferTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            BankTransfersParserFoonesh parser = new BankTransfersParserFoonesh();
            var test = parser.GetBankTransfers();
            foreach (var item in test)
            {
                Debug.WriteLine(item.DestinationBank);
                Debug.WriteLine(item.SourceBank);
            }
        }
    }
}
