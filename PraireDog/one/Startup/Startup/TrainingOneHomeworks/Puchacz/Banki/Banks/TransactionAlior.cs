using Startup.TrainingOneHomeworks.Puchacz.Banki.Abstract;

namespace Startup.TrainingOneHomeworks.Puchacz.Banki.Banks
{
    public class TransactionAlior : BankTransaction
    {
        private const string BankId = "2490";
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
