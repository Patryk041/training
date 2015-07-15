using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank
{
    public class TerryBankTransfer : BankTransfer
    {
        public string Amount { get; set; }
        public string Title { get; set; }
        public TerryBankAccountInfo DestinationAccountInfo;
        public TerryBankAccountInfo SourceAccountInfo;

        //konstruktor
        public TerryBankTransfer(string amount = null, string destNr = null, string destName = null, string srcNr = null,
            string srcName = null, string destBank = null, string srcBank = null, string title = null, string isSuccessful = null)
        {
            DestinationAccountInfo = new TerryBankAccountInfo()
            {
                AccNr = destNr,
                OwnersName = destName
            };

            SourceAccountInfo = new TerryBankAccountInfo()
            {
                AccNr = srcNr,
                OwnersName = srcName
            };

            Amount = amount;
            DestinationBank = destBank;
            SourceBank = srcBank;
            Title = title;
            IsTransferSuccessful = isSuccessful == "y";
        }

    }
}