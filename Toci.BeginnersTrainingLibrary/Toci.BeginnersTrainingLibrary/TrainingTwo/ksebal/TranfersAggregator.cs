using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.ksebal
{
    public abstract class TranfersAggregator
    {                                                                                        
        //utworzyc dedykowane file parsery dziedzicace po TransferFileParser dla okreslonych plikow, najlepiej
        //przez fabryke, zebrac listy transfer entity i zwrocic wszystkie 'przelewy'
        public abstract List<TransferEntity> GetAllTransfers(List<string> filePathsList);

        public abstract List<string> SearchTransferFiles();
    }
}

/*
  public List<string> FilesList()
        {
            return Directory.GetFiles(@"..\..\..\Toci.BeginnersTrain+ingLibrary\TrainingTwo\data").ToList();

 
        }
*/