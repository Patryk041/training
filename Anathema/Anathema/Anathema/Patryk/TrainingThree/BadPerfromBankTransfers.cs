using System.Collections.Generic;
using Anathema.Generics.Chor;
using Anathema.Patryk.TrainingTwo.Banks;
using Anathema.Patryk.TrainingTwo.Banks.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers;
using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingThree
{
    public class BadPerfromBankTransfers
    {
        private IBanktransferLogic _banktransferLogic;


        public BadPerfromBankTransfers()
        {
            _banktransferLogic = new BanktransferLogic();
        }

        public void PerformTransfers(string path)
        {
            List<BankTransfer> bankTransfers = _banktransferLogic.GetAllBanktransfers(path);

            /*foreach (var transfer in bankTransfers)
            {
                SendTransfer(transfer);
            }*/

            ///bankTransfers.ForEach(SendTransfer);

        }
    }
}