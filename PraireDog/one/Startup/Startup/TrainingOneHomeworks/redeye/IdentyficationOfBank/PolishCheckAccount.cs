using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank.Interfaces;
using System.Numerics;

namespace Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank
{
    public class PolishCheckAccount : ICheckBankFromNrAccount
    {
        private const string path = @"http://www.nbp.pl/banki_w_polsce/ewidencja/dz_bank_jorg.txt";
        private Encoding en = Encoding.GetEncoding(852);

        private Dictionary<string, string> BankNames;

        public PolishCheckAccount()
        {
            IMakeDictionaryFromFile dff = new PolishDictionaryFromFile();
            BankNames = dff.MakeDictionary(path, en);
        }

        public string GetNameOfBank(string account)
        {
            string name = null;

            //account = Regex.Replace(account, "PpLl ", "");
            account = account.RemoveUnnecesarySigns("PpLl ");
            decimal numberAccount;

            if (!(CheckAccountNember(account)))
            {
                return "Nieprawidłowy numer konta";
            }



            return name;
        }


        private bool CheckAccountNember(string accountNumber)
        {
            string tempNumber = "PL" + accountNumber;

            if (tempNumber.Length != 28)
                return false;


            string prefix = tempNumber.Substring(0, 4);
            tempNumber = tempNumber.Remove(0, 4) + prefix;
            tempNumber = tempNumber.Replace("PL", "2521");

            BigInteger bigInt;                

            if (!(BigInteger.TryParse(tempNumber,out bigInt)))
                return false;


            BigInteger reszta = bigInt % 97;

            if (reszta == 1)
                return true;

            return false;
        }
    }
}