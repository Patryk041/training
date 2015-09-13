using System.Collections.Generic;
using Anathema.Generics.Chor;
using Anathema.Patryk.TrainingTwo.Banks.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers;
using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks
{
    public class PerfromBankTransfers
    {

        //interfejs który wymusza na klasie dostarczenie metody, z której pobierzemy listę przelewów
        private IBanktransferLogic _banktransferLogic;

        private AbstractChainOfResponsibility<BankTransferHandler, BankTransfer> chainOfResponsibility;

        public PerfromBankTransfers()
        {
            _banktransferLogic = new BanktransferLogic();
            chainOfResponsibility = new ChorBankTransferHandler();
        }


        //na wejsciu dostajemy plik, który może mieć rózne rozszerzenia, np : xmla txt pdf json
        //musimy na podstawie danych w tym pliku utowrzeć listę przelewów ( klasa BankTransfer)
        //Następnie przelewy przetwarzamy w chain of responsibility

        public void PerformTransfers(string path)
        {
            List<BankTransfer> bankTransfers = _banktransferLogic.GetAllBanktransfers(path);


            //przetwarzanie przelewów w chain of responsibility
            foreach (var transfer in bankTransfers)
            {
                chainOfResponsibility.Handle(transfer);
            }

            //altenratywna metoda przetwarzania przelewow w LINQ
            bankTransfers.ForEach(chainOfResponsibility.Handle);
        }

    }
}