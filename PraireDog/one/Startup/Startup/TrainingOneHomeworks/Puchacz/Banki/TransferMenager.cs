using System.Collections.Generic;
using Startup.TrainingOneHomeworks.Puchacz.Banki.Abstract;

namespace Startup.TrainingOneHomeworks.Puchacz.Banki
{
    public class TransferMenager
    {
        public bool DoAll(List<Transfer> transferlist)
        {
            var transactionPair = new List<BankTransaction>();
            foreach (var item in transferlist)
            {
                transactionPair = TransactionFactory.CreateBankTransactions(item);
                foreach (var item1 in transactionPair)
                {
                    switch (item1.TransactionType)
                    {
                        case "income":
                            item1.NotifyIncome();
                            break;
                        case "outcome":
                            item1.NotifyOutcome();
                            break;
                    }
                }
            }
            return true;
        }
    }
}
