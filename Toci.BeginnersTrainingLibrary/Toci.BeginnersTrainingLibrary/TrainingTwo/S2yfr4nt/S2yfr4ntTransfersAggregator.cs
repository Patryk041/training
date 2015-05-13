using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.S2yfr4nt
{
    public class S2yfr4ntTransfersAggregator : TranfersAggregator
    {
        private const string FilePath = @"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data";

        public override List<TransferEntity> GetAllTransfers(List<string> filePathsList)
        {
            List<TransferEntity> transfers = new List<TransferEntity>();
            foreach (var item in filePathsList)
            {
                //var res = S2yfr4ntTransferFileParserFactory.FilesListDelegate.ContainsKey(item) ? S2yfr4ntTransferFileParserFactory.FilesListDelegate[item]() : throw new Exception("Nie ma takiego banku");

                transfers.AddRange(S2yfr4ntTransferFileParserFactory.FilesListDelegate[Path.GetFileName(item)]().OpenFile(item));
            }
            return transfers;
        }

        public override List<string> SearchTransferFiles()
        {
            return Directory.GetFiles(FilePath).ToList();
        }
    }
}
