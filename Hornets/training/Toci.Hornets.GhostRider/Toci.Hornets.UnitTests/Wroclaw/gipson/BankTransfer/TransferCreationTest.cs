using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Wroclaw.AdamPast.GipsonKIR;

namespace Toci.Hornets.UnitTests.Wrocław.gipson.BankTransfer
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