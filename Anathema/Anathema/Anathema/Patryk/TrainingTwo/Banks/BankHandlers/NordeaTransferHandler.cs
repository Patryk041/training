using Anathema.Patryk.TrainingTwo.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankHandlers
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