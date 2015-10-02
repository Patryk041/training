using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.Common
{
    public class RzeszowPerformTransfers : PerformTransfers
    {
        protected List<string> RzeszowBanksList = new List<string>
        {
            "TerryBank",
            "Foonesh",
            "Andrzej",
            "SeRaBank"
        };
        protected override List<BankTransfersParser> GetAllParsers()
        {
            var parsersList = new List<BankTransfersParser>();

            foreach (var bank in RzeszowBanksList)
            {
                if (RzeszowParsersFactory.GetHandle(bank) != null) 
                    parsersList.Add(RzeszowParsersFactory.GetHandle(bank));
            }

            return parsersList;
        }

        protected override List<TransferHandle> GetAllHandles()
        {
            var handlersList = new List<TransferHandle>();

            foreach (var bank in RzeszowBanksList)
            {
                if (RzeszowHandlersFactory.GetHandle(bank) != null) 
                    handlersList.Add(RzeszowHandlersFactory.GetHandle(bank));
            }

            return handlersList;
        }
    }
}