using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe
{
    class GliwiceBankParserTransfer : BankTransfersParser 
    {
        public override List<BankTransfer> GetBankTransfers()
        {
            throw new NotImplementedException();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            throw new NotImplementedException();
        }
    }
}
