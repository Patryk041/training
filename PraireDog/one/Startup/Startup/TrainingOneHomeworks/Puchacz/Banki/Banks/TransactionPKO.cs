using Startup.TrainingOneHomeworks.Puchacz.Banki.Abstract;

namespace Startup.TrainingOneHomeworks.Puchacz.Banki.Banks
{
    public class TransactionPKO : BankTransaction
    {
        private const string BankId = "1020";
        public override string GetBankId()
        {
            return BankId;
        }

        public override bool NotifyIncome()
        {
            return true;
        }

        public override bool NotifyOutcome()
        {
            return true;
        }
    }
}
