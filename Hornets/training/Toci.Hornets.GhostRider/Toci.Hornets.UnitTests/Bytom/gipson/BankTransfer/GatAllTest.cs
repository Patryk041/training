using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.gipson.GipsonKIR;

namespace Toci.Hornets.UnitTests.Bytom.gipson.BankTransfer
{
    [TestClass]
    public class GatAllTest
    {
        [TestMethod]
        public void TestAll()
        {
            var gipsonTH = new GipsonPerformTransfers();
            gipsonTH.TransferAll();
        }
    }
}