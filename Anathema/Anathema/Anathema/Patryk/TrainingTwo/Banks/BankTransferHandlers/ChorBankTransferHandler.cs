using System.Collections.Generic;
using Anathema.Generics.Chor;
using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers
{

    public class ChorBankTransferHandler : AbstractChainOfResponsibility<BankTransferHandler, BankTransfer>
    {
        
        public ChorBankTransferHandler()
        {
            Handlers = new List<BankTransferHandler>()
            {
                new BzwbkTransferHandler(),
                new NordeaTransferHandler(),
                new IngTransferHandler(),
                new PekaoBankTransferHandler()
            };
        }
    }
}