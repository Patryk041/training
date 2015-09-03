using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.SemiRafista.KIR
{
    public class SeRaBankTransfer : BankTransfer
    {
        public string DestinationClientName { get; set; }

        public string SourceClientName { get; set; }

        public string DestinationBankNumber { get; set; }

        public string SourceBankNumber { get; set; }

        public string TransferTitle { get; set; }

        public string TransferDate { get; set; }

        public string TransferAmount { get; set; }
    }
}