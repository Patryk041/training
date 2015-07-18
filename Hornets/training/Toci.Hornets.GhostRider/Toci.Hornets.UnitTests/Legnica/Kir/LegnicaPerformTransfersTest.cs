using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Files;

namespace Toci.Hornets.UnitTests.Legnica.Kir
{
    [TestClass]
    public class LegnicaPerformTransfersTest
    {
        [TestMethod]
        public void GetFileContent_WhenFileFromDisc()
        {
            LegnicaPerformTransfers performTransfers = new LegnicaPerformTransfers();
            performTransfers.TransferAll();
        }    
    }
}