using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers
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
    }
}