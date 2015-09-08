namespace Startup.TrainingOneHomeworks.marcin022.bank_1_2
{
    public class AccValidation
    {
        private string AccNumber;
        private string BankId;

        public  AccValidation(string accNumber)
        {
            BankId = CutToId(CheckNumberFormat(accNumber));
        }

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

        public string GetBankId()
        {
            return BankId;
        }
    }
}