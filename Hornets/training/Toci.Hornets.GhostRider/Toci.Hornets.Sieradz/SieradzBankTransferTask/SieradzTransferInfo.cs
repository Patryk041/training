namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public class SieradzTransferInfo
    {
        public string SourceAccountName { get; set; }
        public string DestinationAccountName { get; set; }
        public string Amount { get; set; }
        public string SourcePersonName { get; set; }
        public string DestinationPersonName { get; set; }
        public string TransferDate { get; set; }
        public string TransferTitle { get; set; } 
    }
}