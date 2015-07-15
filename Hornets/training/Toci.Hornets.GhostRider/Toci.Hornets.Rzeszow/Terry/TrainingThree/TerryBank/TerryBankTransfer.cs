using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Rzeszow.Terry.TrainingThree.Bank;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank
{
    public class TerryBankTransfer : BankTransfer
    {
        public int Amount { get; set; }
        public string Title { get; set; }
        public TerryBankAccountInfo DestinationAccountInfo;
        public TerryBankAccountInfo SourceAccountInfo;

        //konstruktor
        public TerryBankTransfer(string amount, string destNr, string destName, string srcNr, 
            string srcName, string destBank, string srcBank, string title, string isSuccessful)
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

            Amount = int.Parse(amount);
            DestinationBank = destBank;
            SourceBank = srcBank;
            Title = title;
            IsTransferSuccessful = isSuccessful == "y";
        }

    }
}