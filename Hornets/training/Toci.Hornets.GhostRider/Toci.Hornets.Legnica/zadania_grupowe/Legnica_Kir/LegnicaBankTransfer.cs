using System;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir
{
    public class LegnicaBankTransfer : BankTransfer
    {
        private const char space = '\t';
        public string DestinationBankNumber { get; set; }

        public string SourceBankNumber { get; set; }

        public string Title { get; set; }

        public float Amount { get; set; }

        public DateTime Date{ get; set; }

        public override string ToString()
        {
            return SourceBank+space+DestinationBank+space+DestinationBankNumber+space+SourceBankNumber+space+Title+space+Amount+space+Date+"\n";
        }
    }
}