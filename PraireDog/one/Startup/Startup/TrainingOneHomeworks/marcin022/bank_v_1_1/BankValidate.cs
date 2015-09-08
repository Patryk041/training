using System;
using System.Collections.Generic;

namespace Startup.TrainingOneHomeworks.marcin022.bank_1_2
{
    public class BankValidate
    {
        private AccValidation accVal;
        private string AccNumber;
        private string BankId;

       

        public BankValidate(string accNumber)
        {
            accVal=new AccValidation(accNumber);
            CreateBank(accVal.GetBankId());
        }

        private static Dictionary<string, Func<IBank>> bankDictionary = new Dictionary<string, Func<IBank>>
        {
            {"1020", () => new BankPekao()},
            {"1160", () => new BankMillenium()}
        };

        public static Func<IBank> CreateBank(string id)
        {
            return bankDictionary.ContainsKey(id) ? bankDictionary[id] : null;
        }

        
    }
}