using System.Collections.Generic;
using System.Linq;
using Anathema.Generics.Chor;
using Anathema.Patryk.TrainingOne.Cars.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers;
using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks
{
    public class PerfromBankTransfers
    {

        private IBanktransferLogic _banktransferLogic;

        private AbstractChainOfResponsibility<BankTransferHandler, BankTransfer> chainOfResponsibility;

        public PerfromBankTransfers()
        {
            _banktransferLogic = new BanktransferLogic();
            chainOfResponsibility = new ChorBankTransferHandler();
        }

        public PerfromBankTransfers(IBanktransferLogic banktransfer)
        {
            _banktransferLogic = banktransfer;
            chainOfResponsibility = new ChorBankTransferHandler();
        }

        public void PerformTransfers(string path)
        {
            if (path == null) return;

            List<BankTransfer> bankTransfers = _banktransferLogic.GetAllBanktransfers(path);

           /* foreach (var transfer in bankTransfers)
            {
                chainOfResponsibility.Handle(transfer);
            }*/

            bankTransfers.ForEach(chainOfResponsibility.Handle);

        }

    }
}