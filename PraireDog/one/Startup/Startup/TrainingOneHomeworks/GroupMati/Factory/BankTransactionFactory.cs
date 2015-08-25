using System.Collections.Generic;
using System.Collections.Specialized;
using Startup.TrainingOneHomeworks.GroupMati.Banks;
using Startup.TrainingOneHomeworks.Mati.InterfaceBanks;

namespace Startup.TrainingOneHomeworks.Mati.Banks
{
    public class FabricBankTransaction : IBankTransactionFactory
    {
      

        protected Dictionary<string, BankTransaction> BankDictionary = new Dictionary<string, BankTransaction>()
        {
            {"1111", new AliorTransactionBank() },
           // {"1112", new BgzTransactionBank() }
        };
        

        public bool TryGetTransaction(string key, out BankTransaction bankTransaction)
        {
            return BankDictionary.TryGetValue(key, out bankTransaction);
        
        }
    }
}