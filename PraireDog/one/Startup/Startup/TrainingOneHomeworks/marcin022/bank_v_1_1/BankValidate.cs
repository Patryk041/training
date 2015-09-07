using System;
using System.Collections.Generic;

namespace Startup.TrainingOneHomeworks.marcin022.bank_1_2
{
    public class BankValidate
    {
        private string AccNumber;
        private string BankId;

        public string CheckNumberFormat(string accNumber)
        {
            accNumber.Replace(" ", "");
            if (accNumber.Length == 28)
            {
                string temp = accNumber.Substring(2);
                accNumber = temp;
                return accNumber;
            }
            else
            {
                return accNumber;
            }
        }

        public string CutToId(string fullnumner)
        {
            
            BankId = fullnumner.Substring(2, 4);
            return BankId;
        }

        public BankValidate(string accNumber)
        {
            string id = CutToId(CheckNumberFormat(accNumber));
            CreateBank(id);
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