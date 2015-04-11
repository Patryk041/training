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
            ZieluTransferFileParserFactory bankFactory = new ZieluTransferFileParserFactory();
            var transfers = new List<TransferEntity>();
            return filePathsList.Aggregate(transfers, (current, item) => current.Concat(bankFactory.GetTransferFileParser(item.GetFileName()).OpenFile(item)).ToList());
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
