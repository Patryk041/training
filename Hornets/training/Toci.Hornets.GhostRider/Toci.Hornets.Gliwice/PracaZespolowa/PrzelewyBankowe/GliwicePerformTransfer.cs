using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe
{
    class GliwicePerformTransfer : PerformTransfers
    {
        protected override List<BankTransfersParser> GetAllParsers()
        {
            throw new NotImplementedException();
        }

        protected override List<TransferHandle> GetAllHandles()
        {
            throw new NotImplementedException();
        }
    }
}
