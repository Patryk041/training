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
            var transfers = new List<TransferEntity>();
            try
            {
//                return filePathsList.Aggregate(transfers,
//                    (current, item) =>
//                        current.Concat(
//                            ZieluTransferFileParserFactory.GetTransferFileParser(item.GetFileName()).OpenFile(item))
//                            .ToList());
                foreach (var item in filePathsList)
                {
                   transfers.AddRange(ZieluTransferFileParserFactory.GetTransferFileParser(item.GetFileName()).OpenFile(item));
                }
                return transfers;
            }
            catch (Exception)
            {
                return null;
            }
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
