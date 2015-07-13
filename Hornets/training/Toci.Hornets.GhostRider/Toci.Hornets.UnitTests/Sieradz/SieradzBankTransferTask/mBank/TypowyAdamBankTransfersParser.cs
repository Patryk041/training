using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.UnitTests.Sieradz.SieradzBankTransferTask.mBank
{
    public class TypowyAdamBankTransfersParser : BankTransfersParser
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