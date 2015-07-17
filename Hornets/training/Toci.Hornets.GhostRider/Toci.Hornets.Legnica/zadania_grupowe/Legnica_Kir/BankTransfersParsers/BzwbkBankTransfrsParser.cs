using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.BankTransfersParsers
{
    public class BzwbkBankTransfrsParser : BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
            return new List<BankTransfer>();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            return new BankTransfer();
        }
    }
}