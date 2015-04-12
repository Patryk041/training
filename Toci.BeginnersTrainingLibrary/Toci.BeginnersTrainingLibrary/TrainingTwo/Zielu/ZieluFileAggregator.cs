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
            //ZieluTransferFileParserFactory bankFactory = new ZieluTransferFileParserFactory();
            var transfers = new List<TransferEntity>();
            //GetAllTransfers(GetFilePath())
            try
            {
                return filePathsList.Aggregate(transfers,
                    (current, item) =>
                        current.Concat(
                            ZieluTransferFileParserFactory.GetTransferFileParser(item.GetFileName()).OpenFile(item))
                            .ToList());
            }
            catch (Exception e)
            {
                var test = e;
                return null;
            }
        }

        public override List<string> SearchTransferFiles()
        {
            return GetFilePath();
        }

        private List<string> GetFilePath()
        {
            return Directory.GetFiles(FilePath).ToList();
        }

        public List<TransferEntity> ZieluGetAllTransfers()
        {
            return GetAllTransfers(GetFilePath());
        }
    }
}
