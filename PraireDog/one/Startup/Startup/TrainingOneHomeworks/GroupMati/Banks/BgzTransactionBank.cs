using System;

namespace Startup.TrainingOneHomeworks.Mati.Banks
{
    public class BgzTransactionBank : BankTransaction
    {
        private const string bankName = "Bank BGZ";

        public override void IncommingTransaction()
        {
            throw new NotImplementedException();
        }

        public override void OutCommingTransaction()
        {
            throw new NotImplementedException();
        }

        public override string GetBankName()
        {
            return bankName;
        }
    }
}