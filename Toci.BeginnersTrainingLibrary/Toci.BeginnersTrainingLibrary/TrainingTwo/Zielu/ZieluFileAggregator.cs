using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu.Extensions;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu
{
    public class ZieluFileAggregator:TranfersAggregator
    {
        private const string FilePath = @"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data";
        public override List<TransferEntity> GetAllTransfers(List<string> filePathsList)
        {
            List<TransferEntity> transfers = new List<TransferEntity>();
                filePathsList.ForEach(item => transfers.AddRange(ZieluTransferFileParserFactory.GetTransferFileParser(item).OpenFile(item)));
                return transfers;
        }

        public override List<string> SearchTransferFiles()
        {
            return Directory.GetFiles(FilePath).ToList();
        }

        public List<TransferEntity> ZieluGetAllTransfers()
        {
            return GetAllTransfers(SearchTransferFiles());
        }
    }
}
