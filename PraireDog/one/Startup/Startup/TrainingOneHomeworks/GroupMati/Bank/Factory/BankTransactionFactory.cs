using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Startup.TrainingOneHomeworks.GroupMati.Bank.Factory;
using Startup.TrainingOneHomeworks.GroupMati.Banks;
using Startup.TrainingOneHomeworks.Mati.InterfaceBanks;

namespace Startup.TrainingOneHomeworks.Mati.Banks
{
    public class FactoryBankTransaction<T>  : AbstractFactoryBankTransaction<T>
    {

        /// <summary>
        /// Delegata zrobic
        /// </summary>
        protected Dictionary<string, Func<T>> BankDictionary = new Dictionary<string, Func<T>>();
        public FactoryBankTransaction()
        {
            //IBankTransactionFactory przyklad;
            //Dictionary<string, bool> result = BankDictionary(przyklad);
          
            BankDictionary.Add("1111", () => (T)(object)new AliorTransactionBank()) ;
            // {"1112", () => new BgzTransactionBank() },
            // {"1113", new BgzTransactionBank() },
            // {"1114", new BgzTransactionBank() },
            // {"1115", new BgzTransactionBank() },
            // {"1116", new BgzTransactionBank() },
            // {"1117", new BgzTransactionBank() },
            // {"1118", new BgzTransactionBank() },
            // {"1119", new BgzTransactionBank() },
            // {"1120", new BgzTransactionBank() },
            // {"1121", new BgzTransactionBank() },
            // {"1122", new BgzTransactionBank() },
            // {"1123", new BgzTransactionBank() },
            // {"1124", new BgzTransactionBank() },
            // {"1125", new BgzTransactionBank() },
            // {"1126", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
            // {"1112", new BgzTransactionBank() },
        }

        public void Add(string key, object value) 
        {
           // BankDictionary.Add(key, value);
        }

        public Func<T, bool> GetValue(string key) 
        {
            return  BankDictionary[key];
        }
        public bool TryGetTransaction(string key, Func<T, bool> bankTransaction)
        {
            return BankDictionary.TryGetValue(key, out bankTransaction);
        
        }
    }
}