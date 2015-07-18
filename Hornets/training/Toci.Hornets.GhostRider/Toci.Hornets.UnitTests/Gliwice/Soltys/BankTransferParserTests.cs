using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys;

namespace Toci.Hornets.UnitTests.Gliwice.Soltys
{
    [TestClass]
    public class BankTransferParserTests
    {
        [TestMethod]
        public void Can_Correctly_Parse_Bank_Transfer_String()
        {
            var parser = new SoltysBankTransferParser();

            var result = parser.GetBankTransfers();

            Assert.AreEqual("ING", result[0].SourceBank);
            Assert.AreEqual("PKO", result[1].SourceBank);
        }
    }
}
