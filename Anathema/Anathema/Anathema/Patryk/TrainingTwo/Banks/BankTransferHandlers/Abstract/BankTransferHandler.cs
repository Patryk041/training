using Anathema.Generics.Chor;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract
{
 
    public abstract class BankTransferHandler : IHandler<BankTransfer>
    {
        protected string BankName;

        public void Handle(BankTransfer entity)
        {
            if (IsMyDestination(entity))
                SendTransfer(entity);
        }

        protected virtual bool IsMyDestination(BankTransfer entity)
        {
            return entity.DestinationBankName == BankName;
        }

        protected abstract void SendTransfer(BankTransfer entity);
    }

    
}