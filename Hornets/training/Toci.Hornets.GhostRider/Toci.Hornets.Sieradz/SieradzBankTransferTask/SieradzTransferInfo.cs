namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public class SieradzTransferInfo
    {
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountNumber { get; set; }
        public string Amount { get; set; }
        public string SourcePersonName { get; set; }
        public string DestinationPersonName { get; set; }
        public string TransferDate { get; set; }
        public string TransferTitle { get; set; } 
    }
}