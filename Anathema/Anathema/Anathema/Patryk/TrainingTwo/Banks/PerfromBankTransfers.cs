using System.Collections.Generic;
using Anathema.Generics.Chor;
using Anathema.Patryk.TrainingTwo.Banks.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.BankHandlers;
using Anathema.Patryk.TrainingTwo.Models;

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


        //xmla txt pdf json
        public void PerformTransfers(string path)
        {
            List<BankTransfer> bankTransfers = _banktransferLogic.GetAllBanktransfers(path);

            bankTransfers.ForEach(chainOfResponsibility.Handle);

            foreach (var transfer in bankTransfers)
            {
                chainOfResponsibility.Handle(transfer);
            }
        }
    }
}