using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Files;

namespace Toci.Hornets.UnitTests.Legnica.Kir
{
    [TestClass]
    public class LegnicaFileOperationTests
    {
        [TestMethod]
        public void GetFileContent_WhenFileFromDisc()
        {
           /* NordeaBankTransfersParser bankTransfersParser = new NordeaBankTransfersParser(new LegnicaFileOperation(),
                                                            @"..\..\..\Toci.Hornets.UnitTests\Legnica\Kir\Files\t1.txt");
            var banktransfers = bankTransfersParser.GetBankTransfers();*/
            var path = AlmostLikeADatebase.GetBankTransferToDo("Nordea");

           // var x = Directory.GetFiles(@"c:\Test\");
        }       
    }
}