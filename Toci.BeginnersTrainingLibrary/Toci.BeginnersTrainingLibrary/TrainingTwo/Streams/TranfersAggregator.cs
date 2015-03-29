using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Streams
{
    public abstract class TranfersAggregator
    {
        //utworzyc dedykowane file parsery dziedzicace po TransferFileParser dla okreslonych plikow, najlepiej
        //przez fabryke, zebrac listy transfer entity i zwrocic wszystkie 'przelewy'
        public abstract List<TransferEntity> GetAllTransfers(List<string> filePathsList);
    }
}
