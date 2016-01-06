using System.Linq;
using System.Numerics;

namespace Anathema.Igor.Banks_New_Solution.AccountNumberValidator
{
    public class AccountNumberValidator
    {
        private string accountNumber;

        public AccountNumberValidator(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public bool isAccountNumberCorrect()
        {
            if (isIBANAccountNumber()) return isIBANAccountNumberCorrect();
            return isNRBAccountNumberCorrect();
        }

        public bool isIBANAccountNumberCorrect()
        {
            var result = false;
            if(isIBANAccountNumber())
            {
                if(FirstTwoSignsAreString())
                {
                    if(RestOfSignsAreDigits())
                    {
                        result = isIBANControlAmountCorrect();
                    }
                }
            }
            return result;
        }

        public bool isNRBAccountNumberCorrect()
        {
            var accountNumberSave = accountNumber;
            bool result;
            
            accountNumber = "PL" + accountNumber;
            result = isIBANAccountNumberCorrect();
            accountNumber = accountNumberSave;

            return result;
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
            return accountNumber.Substring(2).All(char.IsDigit);
        }

        protected bool isIBANControlAmountCorrect()
        {
            var tmpAccountNumber = accountNumber;

            tmpAccountNumber = getLastSigns(tmpAccountNumber) + getFirstFourSigns(tmpAccountNumber);
            tmpAccountNumber = changeStringLettersToThemAlphabetNumbers(tmpAccountNumber);

            BigInteger controlAmount = BigInteger.Parse(tmpAccountNumber);

            return (controlAmount % 97) == 1;
        }

        protected string changeStringLettersToThemAlphabetNumbers(string str)
        {
            var result = "";

            str = str.ToLower();
            foreach(var sign in str)
            {
                if (isSmallLetter(sign)) result += (sign - 'a' + 10).ToString();
                else result += sign.ToString();
            }

            return result;
        }

        protected string getLastSigns(string str)
        {
            return str.Substring(4, str.Length - 4);
        }

        protected string getFirstFourSigns(string str)
        {
            return str.Substring(0, 4);
        }

        protected bool isSmallLetter(char sign)
        {
            return sign >= 'a' && sign <= 'z';
        }

        protected bool isAccountNumberLengthCorrect()
        {
            return accountNumber.Length == 26 || accountNumber.Length == 28;
        }
    }
}
