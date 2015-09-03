using System;
using Toci.Hornets.GhostRider.Kir;


namespace Toci.Hornets.Bytom.gipson.GipsonKIR
{
    public class GipsonBankTransfer :BankTransfer
    {
        //public string DestinationBank { get; set; }

        //public string SourceBank { get; set; }

        //public bool IsTransferSuccessful { get; set; }

        public double TransferAmmount { get; set; }

        public string TransferTitle { get; set; }

        public string Waluta { get; set; }

        public DateTime TransferDate { get; set; }

        public GipsonBankAccount SendingAccount;

        public GipsonBankAccount ReceivingAccount;




    }
}