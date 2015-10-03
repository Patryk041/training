namespace Startup.TrainingOneHomeworks.Erloon
{
    public class BankAccountNumber: IIdentificationBankAccountNumber
    {
        public string CheckBank(AccountNumber accountNumber)
        {
            string BankName;
            var fundBank = BamkList.ListAllBank.Find(bank => bank.BranchBankId.Equals(accountNumber.AcountNumber.Substring(2, 8)));
            if (fundBank == null)
            {
                BankName = "Nie ma takiego banku";
            }
            else
            {
                BankName = string.Format("Nazwa banku: {0} oddział w {1}", fundBank.BankName, fundBank.BranchBankName);
            }
            return BankName;
        }
    }
}