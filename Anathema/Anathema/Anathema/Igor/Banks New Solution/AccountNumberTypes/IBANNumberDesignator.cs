namespace Anathema.Igor.Banks_New_Solution.AccountNumberTypes
{
    public class IBANNumberDesignator : NRBNumberDesignator
    {
        public string countryCode { get; protected set; }

        public IBANNumberDesignator(string originalNumber) 
            : base(makeNumberNRB(originalNumber))
        {
            this.originalNumber = originalNumber;
            accountNumberValidator = new AccountNumberValidator.AccountNumberValidator(originalNumber);
            designateValuesIfNumberIsCorrect();
        }

        protected override void designateValuesIfNumberIsCorrect()
        {
            if (accountNumberValidator.isAccountNumberCorrect())
            {
                if (accountNumberValidator.isNRBAccountNumber()) originalNumber = makeNumberIBAN(originalNumber);

                designateCountryCode();
                originalNumber = makeNumberNRB(originalNumber);
                designateInstitutionID();
                designateBranchID();
                designateControlDigit();
                designateClientAccountNumber();
                designateControlAmount();
                designateBankRoutingNumber();
                originalNumber = makeNumberIBAN(originalNumber);
            }
            else throw new System.Exception("Account number is incorrect.");
        }

        protected void designateCountryCode()
        {
            countryCode = originalNumber.Substring(0, 2);
        }

        static string makeNumberNRB(string number)
        {
            AccountNumberValidator.AccountNumberValidator validator = new AccountNumberValidator.AccountNumberValidator(number);
            if (validator.isIBANAccountNumber())
            {
                number = number.Substring(2);
            }
            return number;
        }

        static string makeNumberIBAN(string number)
        {
            AccountNumberValidator.AccountNumberValidator validator = new AccountNumberValidator.AccountNumberValidator(number);
            if(validator.isNRBAccountNumber())
            {
                number = "PL" + number;
            }
            return number;
        }
    }
}
