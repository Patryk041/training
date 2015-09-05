using System.Collections.Generic;
using Startup.TrainingOneHomeworks.Puchacz.Banki.Abstract;

namespace Startup.TrainingOneHomeworks.Puchacz.Banki
{
    static class TransactionFactory
    {
        public static List<BankTransaction> CreateBankTransactions(Transfer transfer)
        {

            var transactionPairList = new List<BankTransaction>();
            string senderaccnumcut = transfer.SenderNumber.Remove(0, 2);
            senderaccnumcut = senderaccnumcut.Remove(4, 20);
            string recieveraccnumcut = transfer.RecieverNumber.Remove(0, 2);
            recieveraccnumcut = recieveraccnumcut.Remove(4, 20);

            int i = 0;
            foreach (var item in Reflection.GetEnumerableOfType<BankTransaction>())
            {
                if (item.GetBankId() == senderaccnumcut)
                {
                    transactionPairList.Add(item);  // powtarza sie - lepiej funkcją :D
                    transactionPairList[i].CashAmount = transfer.CashAmount;
                    transactionPairList[i].SenderAdress = transfer.SenderAdress;
                    transactionPairList[i].RecieverAdress = transfer.RecieverAdress;
                    transactionPairList[i].TransferTitle = transfer.TransferTitle;
                    transactionPairList[i].TransactionType = "outcome";
                    i++;
                }

                if (item.GetBankId() == recieveraccnumcut && i < 2)
                {
                    transactionPairList.Add(item);
                    transactionPairList[i].CashAmount = transfer.CashAmount;
                    transactionPairList[i].SenderAdress = transfer.SenderAdress;
                    transactionPairList[i].RecieverAdress = transfer.RecieverAdress;
                    transactionPairList[i].TransferTitle = transfer.TransferTitle;
                    transactionPairList[i].TransactionType = "income";
                    i++;
                }
            }
            return transactionPairList;
        }
    }
}
