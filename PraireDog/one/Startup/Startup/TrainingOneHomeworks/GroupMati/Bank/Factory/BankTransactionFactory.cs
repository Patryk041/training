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
        protected Dictionary<string, Func<T, bool>> BankDictionary = new Dictionary<string,Func<T,bool>>();
        public FactoryBankTransaction()
        {
            
            BankDictionary.Add("1111", x => Equals(new AliorTransactionBank(),typeof(T)));
            //BankDictionary.Add("asdf",x => Equals(new string("32".ToCharArray()).GetType(),typeof(T)));
        }


        public void Add<T>(string key, Func<T,bool> value) where T : class
        { 
          // BankDictionary.Add(key, value);
        }

        public Func<T, bool> GetValue(string key)
        {
            return null;
            //return  BankDictionary[key];
        }
        public bool TryGetTransaction(string key, Func<T, bool> bankTransaction)
        {
            return true;
            //return BankDictionary.TryGetValue(key, out bankTransaction);

        }
    }
}