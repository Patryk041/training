using System.Collections.Generic;
using Toci.Hornets.BankFactory.Chor;
using Toci.Hornets.BankFactory.Models;

namespace Toci.Hornets.BankFactory.Bank.BankHandlers
{
    public class ChorBankTransferHandler : AbstractChainOfResponsibility<BankTransferHandler, BankTransfer>
    {
        public ChorBankTransferHandler()
        {
            Handlers = new List<BankTransferHandler>()
            {
                new BzwbkTransferHandler(),
                new NordeaTransferHandler(),
                new IngTransferHandler()
            };

        }
    }
}