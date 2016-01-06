namespace Anathema.Igor.Banks_New_Solution.AccountNumberTypes
{
    public class NRBNumberDesignator
    {
        public ushort institutionID { get; protected set; }
        public byte branchID { get; protected set; }
        public byte controlDigit { get; protected set; }
        public ulong clientAccountNumber { get; protected set; }
        public byte controlAmount { get; protected set; }
        public int bankRoutingNumber { get; protected set; }
        public string originalNumber { get; protected set; }

        protected AccountNumberValidator.AccountNumberValidator accountNumberValidator;

        public NRBNumberDesignator(string originalNumber)
        {
            this.originalNumber = originalNumber;
            accountNumberValidator = new AccountNumberValidator.AccountNumberValidator(originalNumber);
            designateValuesIfNumberIsCorrect();
        }

        protected virtual void designateValuesIfNumberIsCorrect()
        {
            var isNumberCorrect = accountNumberValidator.isNRBAccountNumber() && accountNumberValidator.isAccountNumberCorrect();

            if (isNumberCorrect)
            {
                designateInstitutionID();
                designateBranchID();
                designateControlDigit();
                designateClientAccountNumber();
                designateControlAmount();
                designateBankRoutingNumber();
            }
            else throw new System.Exception("Account number is incorrect.");
        }

        protected void designateControlAmount()
        {
            controlAmount = byte.Parse(originalNumber.Substring(0, 2));
        }

        protected void designateInstitutionID()
        {
            institutionID = ushort.Parse(originalNumber.Substring(2, 4));
        }

        protected void designateBranchID()
        {
            branchID = byte.Parse(originalNumber.Substring(6, 3));
        }
        
        protected void designateControlDigit()
        {
            controlDigit = byte.Parse(originalNumber.Substring(9, 1));
        }

        protected void designateClientAccountNumber()
        {
            clientAccountNumber = ulong.Parse(originalNumber.Substring(10, 16));
        }

        protected void designateBankRoutingNumber()
        {
            bankRoutingNumber = int.Parse(originalNumber.Substring(2, 8));
        }
    }
}
