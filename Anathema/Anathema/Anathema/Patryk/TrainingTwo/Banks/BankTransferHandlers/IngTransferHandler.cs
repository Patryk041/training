using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers
{
    public class IngTransferHandler : BankTransferHandler
    {
        public IngTransferHandler()
        {
            BankName = "Ing";
        }

        protected override void SendTransfer(BankTransfer entity)
        {
            entity.TransferSuccessful = true;
        }
    }
}