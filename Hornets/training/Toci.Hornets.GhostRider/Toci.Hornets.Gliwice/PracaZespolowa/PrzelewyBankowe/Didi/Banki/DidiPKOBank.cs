using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi.Banki
{
    class DidiPKOBank : TransferHandle ,IBank
    {
        public DidiPKOBank(BankTransfer transferBank)
        {
            BankName = transferBank.DestinationBank; 
        }
        protected override bool Send(BankTransfer transfer)
        {
            return true; 
        }
    }
}
