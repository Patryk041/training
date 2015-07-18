using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi
{
    public class DidiINGBank : TransferHandle, IBank
    {
       public DidiINGBank()
       {
           BankName = "ING";
       }

        protected override bool Send(BankTransfer transfer)
        {
            IsMyDestination(transfer);

            return true; 
        }
    }
}
