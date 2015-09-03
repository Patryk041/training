namespace Startup.TrainingOneHomeworks.Lurppis.Bank.Banks
{
    public class AliorBank : Abstract.Bank
    {
        public AliorBank(string bankName, int id, string name, int amount, string lastName) : base(bankName: bankName, id: id, name: name, amount: amount, lastName: lastName)
        {
        }
    }
}