using Toci.Hornets.BankFactory.Chor;
using Toci.Hornets.BankFactory.Models;

namespace Toci.Hornets.BankFactory.Bank.BankHandlers
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

        protected abstract double ShowAccountBalance();
    }


}