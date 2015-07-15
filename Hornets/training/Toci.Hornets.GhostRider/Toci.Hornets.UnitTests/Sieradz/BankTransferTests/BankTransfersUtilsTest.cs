using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.SieradzBankTransferTask;

namespace Toci.Hornets.UnitTests.Sieradz.BankTransferTests
{
    [TestClass]
    public class BankTransfersUtilsTest
    {
        private readonly Dictionary<string, string> _bankNamesAndCodes = new Dictionary<string, string>
        {
            {"1140","mBank"},
            {"2490","Alior"},
            {"1240","Pekao"},
            {"1337","Hellada"},
        }; 
        [TestMethod]
        public void SieradzBankTransfersUtilsTest()
        {
            var util = SieradzBankTransfersUtils.Instance;

            foreach (var nameAndCodePair in _bankNamesAndCodes)
                Assert.AreEqual(util.GetBankName(nameAndCodePair.Key),nameAndCodePair.Value);
        }
    }
}