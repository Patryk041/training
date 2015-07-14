using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.Hellada;

namespace Toci.Hornets.UnitTests.Sieradz.Duch.HW3
{
    [TestClass]
    public class DuchBankTests
    {
        [TestMethod]
        public void DuchFileLoadTest()
        {
            var palsel = new DuchBankTransferParser();
            palsel.GetBankTransfers();
        }
    }
}
