using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers
{

    public class BzwbkTransferHandler : BankTransferHandler
    {

        //interfejs  
        public BzwbkTransferHandler()
        {
            BankName = "Bzwbk";
        }
 
        protected override void SendTransfer(BankTransfer entity)
        {
            entity.TransferSuccessful = true;
        }
    }
}