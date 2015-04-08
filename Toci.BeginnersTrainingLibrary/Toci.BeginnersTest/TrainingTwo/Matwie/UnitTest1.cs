using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
