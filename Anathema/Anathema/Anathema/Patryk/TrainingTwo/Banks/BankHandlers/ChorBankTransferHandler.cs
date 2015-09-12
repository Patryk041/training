using System.Collections.Generic;
using Anathema.Generics.Chor;
using Anathema.Patryk.TrainingTwo.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankHandlers
{
    public class ChorBankTransferHandler : AbstractChainOfResponsibility<BankTransferHandler,BankTransfer>
    {
        public ChorBankTransferHandler()
        {
            Handlers = new List<BankTransferHandler>()
            {
                new BzwbkTransferHandler(),
                new NordeaTransferHandler()
            };

        }

        //CHOR   czy ja moge to obsluzyc
        // jezeli tak to to zrobie :)
    }
}