using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.ProjectElixir
{
    class TransferHandleWroclaw :TransferHandle
    {
        protected override bool Send(BankTransfer transfer)
        {

            if (SendTransfer(transfer))
            {
                
               //logic.. zapisać do pliku przelew w jakiejść postaci
                return true;
            }
            return false;
        }
    }
}
