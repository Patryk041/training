using Toci.Hornets.BankFactory.Models;

namespace Toci.Hornets.BankFactory.Bank.BankHandlers
{
    public class NordeaTransferHandler : BankTransferHandler
    {
        public NordeaTransferHandler()
        {
            BankName = "Nordea";
        }

        protected override void SendTransfer(BankTransfer entity)
        {

        }

        protected override double ShowAccountBalance()
        {
            throw new System.NotImplementedException();
        }
    }
}