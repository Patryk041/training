using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingFour.Disposables;

namespace Toci.BeginnersTest.TrainingFour.Disposables
{
    [TestClass]
    public class DisposablesTest
    {
        [TestMethod]
        public void TestRamExhaust()
        {
            DisposableTester tester = new DisposableTester();

            tester.FinishRam();
        }

        [TestMethod]
        public void TestFileFetcher()
        {
            FileFetcher ff = new FileFetcher();

            ff.FetchFiles(@"D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Toci.BeginnersTrainingLibrary\Toci.BeginnersTrainingLibrary\TrainingFour\Disposables\Data");

            var dupa = ff.test;

        }
    }
}
