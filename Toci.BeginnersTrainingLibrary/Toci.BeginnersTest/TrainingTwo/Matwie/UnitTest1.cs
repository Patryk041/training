using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Matwie;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTest.TrainingTwo.Matwie
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenAndParseFileTest()
        {
            RandomGenericFileParser parser = new RandomGenericFileParser();
            parser.OpenFile(@"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data\multibank.txt");
        }

        [TestMethod]
        public void SearchFilesTest()
        {
            MatwieTransfers transfers = new MatwieTransfers();
            transfers.SearchTransferFiles();
        }

        [TestMethod]
        public void TransfersTest()
        {
            MatwieTransfers transfers = new MatwieTransfers();
            var res = transfers.GetAllTransfers(transfers.SearchTransferFiles());
            Assert.AreEqual(18, res.Count);
        }
    }
}
