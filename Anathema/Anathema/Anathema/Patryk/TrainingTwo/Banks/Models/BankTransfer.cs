namespace Anathema.Patryk.TrainingTwo.Banks.Models
{
    public class BankTransfer
    {
        public string SourceBankName { get; set; }
        public string DestinationBankName { get; set; }
        public double Amount { get; set; }
        public bool TransferSuccessful { get; set; }

        //public string DestinationBankNumber { get; set; }
        //public string TransferDate { get; set; }
        //public string Title { get; set; } 
    }
}