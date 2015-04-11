using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu.Extensions;

namespace Toci.BeginnersTest.TrainingTwo.Zielu
{
    [TestClass]
    class ZieluUnitTest
    {
        [TestMethod]
        public void TestStuffIWrote()
        {
            const string blah = @"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data\ing.txt";
            Assert.IsTrue("ing.txt" == blah.GetFileName());
            ZieluFileAggregator cos = new ZieluFileAggregator();
            Assert.IsTrue(cos.ZieluGetAllTransfers().Count== 18);
        }
    }
}
