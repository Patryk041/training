using System;
using Toci.Hornets.BankFactory.Models;

namespace Toci.Hornets.BankFactory.Bank.BankHandlers
{
    public class IngTransferHandler : BankTransferHandler
    {
        private double _account;

        public IngTransferHandler()
        {
            BankName = "Ing";
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