using Toci.Hornets.BankFactory.Models;

namespace Toci.Hornets.BankFactory.Bank.BankHandlers
{
    public class BzwbkTransferHandler : BankTransferHandler
    {
        private double _account ;
        public BzwbkTransferHandler()
        {
            BankName = "Bzwbk";
        }

        protected override void SendTransfer(BankTransfer entity)
        {
            if (entity.DestinationBankName == "Bzwbk")
            {
                _account += entity.Amount;
                entity.TransferSuccessful = true;
            }
            else
            {
                entity.TransferSuccessful = false;
            }
        }

        protected override double ShowAccountBalance()
        {
            return _account;
        }
    }
}