using System.Collections.Generic;

namespace Startup.TrainingOneHomeworks.AndzejC.Banki
{
    public class TransactionMenager
    {
        protected BankFactory Banks = new BankFactory();
        protected List<Transaction> TransferList;

        public void SendTransfers()
        {
            foreach (var item in TransferList)
            {
                Transaction(item);
            }

        }

        public bool Transaction(Transaction item)
        {

            return true;
        }
    
    }
}