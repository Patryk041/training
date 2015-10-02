namespace Toci.Hornets.Rzeszow.Agata.Kir
{
    public class YaghaBankTransfer : Toci.Hornets.GhostRider.Kir.BankTransfer
    {
        public string TransferNumber { get; set; }
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountNumber { get; set; }
        public string DestinationAccountOwner { get; set; }
        public string Amount { get; set; }
        public string TransferTitle { get; set; }

    }
}