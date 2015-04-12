using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Matwie;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Santi;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Wiosna;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu;

namespace Toci.BeginnersTest.TrainingTwo.Warrior
{
    [TestClass]
    public class FileParsersTest
    {
        [TestMethod]
        public void FileParsersDevsTest()
        {
            List<TranfersAggregator> transfers = new List<TranfersAggregator>()
            {
                new MatwieTransfers(),
                new SantiTransfers(),
                new WiosnaTransfers(),
                new ZieluFileAggregator(),
            };

            foreach (var item in transfers)
            {
                var result = item.GetAllTransfers(item.SearchTransferFiles());
            }
        }
    }
}
