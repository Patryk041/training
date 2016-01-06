using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Igor.Banks_New_Solution.AccountNumberValidator
{
    class AccountNumberValidator
    {
        private string accountNumber;

        public AccountNumberValidator(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public bool isAccountNumberCorrect()
        {
            if(isAccountNumberCorrect())
            {
                return true;
            }
            return false;
        }

        public bool isIBANAccountNumberCorrect()
        {
            if(isIBANAccountNumber())
            {
                if(FirstTwoSignsAreString())
                {
                    if(RestOfSignsAreDigits())
                    {
                        
                    }
                }
            }
            return false;
        }

        public bool isIBANAccountNumber()
        {
            return accountNumber.Length == 28;
        }

        public bool isNRBAccountNumber()
        {
            return accountNumber.Length == 26;
        }

        protected bool FirstTwoSignsAreString()
        {
            return !accountNumber.Substring(0, 2).All(char.IsDigit);
        }

        protected bool RestOfSignsAreDigits()
        {
            return accountNumber.All(char.IsDigit);
        }

        protected bool isIBANControlAmountCorrect()
        {
            var tmpAccountNumberForStringOperations = accountNumber;

            tmpAccountNumberForStringOperations = tmpAccountNumberForStringOperations.Substring(2,
                tmpAccountNumberForStringOperations.Length - 2) +
                tmpAccountNumberForStringOperations.Substring(0, 2);



            return true;
        }

        protected string changeStringLettersToThemAlphabetNumbers(string str)
        {
            var result = "";

            foreach(var sign in )
        }

        protected bool isAccountNumberLengthCorrect()
        {
            return accountNumber.Length == 26 || accountNumber.Length == 28;
        }
    }
}
