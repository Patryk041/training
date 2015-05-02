using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.S2yfr4nt
{
    class S2yfr4ntTransfersAggregator: TranfersAggregator
    {
        private const string FilePath = @"\..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data";

        public override List<TransferEntity> GetAllTransfers(List<string> filePathsList)
        {
            throw new NotImplementedException();
        }

        public override List<string> SearchTransferFiles()
        {
            return Directory.GetFiles(FilePath).ToList();
        }
    }
}
