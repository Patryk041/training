using System.Collections.Generic;
using Toci.Hornets.BankFactory.Chor;
using Toci.Hornets.BankFactory.Bank.Abstract;
using Toci.Hornets.BankFactory.Bank.BankHandlers;
using Toci.Hornets.BankFactory.Models;

namespace Toci.Hornets.BankFactory.Bank
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