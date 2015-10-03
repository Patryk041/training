using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers
{
    public class PekaoBankTransferHandler : BankTransferHandler
    {
        public PekaoBankTransferHandler()
        {
            BankName = "Pekao";
        }

        protected override void SendTransfer(BankTransfer entity)
        {
            
        }
    }
}