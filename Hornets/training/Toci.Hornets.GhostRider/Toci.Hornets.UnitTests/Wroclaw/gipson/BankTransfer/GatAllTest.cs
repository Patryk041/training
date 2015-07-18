using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Wroclaw.AdamPast.GipsonKIR;

namespace Toci.Hornets.UnitTests.Wrocław.gipson.BankTransfer
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