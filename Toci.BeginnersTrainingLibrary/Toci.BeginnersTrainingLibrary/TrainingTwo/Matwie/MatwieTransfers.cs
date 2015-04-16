using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Matwie
{
    public class MatwieTransfers : TranfersAggregator
    {
        private List<TransferEntity> _transfers = new List<TransferEntity>();

        public override List<string> SearchTransferFiles()
        {
            return Directory.GetFiles(@"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data").ToList();
        }

        public override List<TransferEntity> GetAllTransfers(List<string> filePathsList)
        {
            foreach (var path in filePathsList)
            {
                _transfers.AddRange(TransferFileParserFactory.CreateTransferFileParser(path).OpenFile(path));
            }
            return _transfers;
        }
    }
}
