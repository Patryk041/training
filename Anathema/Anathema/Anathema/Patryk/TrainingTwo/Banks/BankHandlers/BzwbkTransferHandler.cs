using Anathema.Patryk.TrainingTwo.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankHandlers
{
    public class BzwbkTransferHandler : BankTransferHandler
    {
        public BzwbkTransferHandler()
        {
            BankName = "Bzwbk";
        }

        protected override void SendTransfer(BankTransfer entity)
        {
                
        }
    }
}