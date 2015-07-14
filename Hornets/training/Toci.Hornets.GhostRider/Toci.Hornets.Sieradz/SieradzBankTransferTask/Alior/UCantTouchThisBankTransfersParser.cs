using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Alior
{
    public class UCantTouchThisBankTransfersParser : BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
            throw new System.NotImplementedException();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            throw new System.NotImplementedException();
        }
    }
}