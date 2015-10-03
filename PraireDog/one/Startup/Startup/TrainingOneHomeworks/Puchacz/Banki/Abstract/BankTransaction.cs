using System;

namespace Startup.TrainingOneHomeworks.Puchacz.Banki.Abstract
{
    public abstract class BankTransaction
    {
        public string CashAmount { get; set; }
        public string TransferTitle { get; set; }
        public string SenderAdress { get; set; }
        public string RecieverAdress { get; set; }
        public string TransactionType { get; set; }

        public virtual string GetBankId()
        {
            throw new Exception("Error - bad bank id");
        }

        public virtual bool NotifyIncome()
        {
            throw new Exception("Error - bad bank id, cannot notify income");
        }

        public virtual bool NotifyOutcome()
        {
            throw new Exception("Error - bad bank id, cannot notify outcome");
        }

    }
}