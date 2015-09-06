namespace Startup.TrainingOneHomeworks.marcin022
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

        public void SelectBank(string bankId)
        {
            switch (bankId)
            {
                case       "1020":
                    BankPekao ob = new BankPekao();
                    ob.ShowName();
                    break;
                case "1160":
                    BankMillenium ob2 = new BankMillenium();
                    ob2.ShowName();
                    break;
                default:
                    BankDefault ob3 = new BankDefault();
                    ob3.ShowName();
                    break;
            }
        }

        public BankValidate(string accNumber)
        {
           string tmp = CutToId(CheckNumberFormat(accNumber));
            SelectBank(tmp);
        }
    }
}