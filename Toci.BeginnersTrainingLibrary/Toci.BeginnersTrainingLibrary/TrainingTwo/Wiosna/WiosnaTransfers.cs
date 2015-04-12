using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Wiosna
{
    public class WiosnaTransfers : TranfersAggregator
    {
        public List<string> FilesList()
        {
            return Directory.GetFiles(@"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data").ToList();
        }
        public override List<TransferEntity> GetAllTransfers(List<string> filePathsList)
        {
            List<TransferEntity> completeListOftraTransferEntities = new List<TransferEntity>();
            
            foreach (var filePath in filePathsList)
            {
               completeListOftraTransferEntities.
                   AddRange(WiosnaFileParserFactory.GetParsedItems(filePath).OpenFile(filePath));
            }

            return completeListOftraTransferEntities;
        }

        public override List<string> SearchTransferFiles()
        {
            return FilesList();
        }
    }
}
