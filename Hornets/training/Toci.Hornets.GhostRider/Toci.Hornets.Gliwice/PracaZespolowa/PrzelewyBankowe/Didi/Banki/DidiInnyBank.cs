using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi.Banki
{
    class DidiInnyBank : TransferHandle, IBank
    {
        // ZLE !!! ;(
        public DidiInnyBank()
        {
            BankName = "inny";
        }
        protected override bool Send(BankTransfer transfer)
        {
            return false;
        }
    }
}
