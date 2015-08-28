namespace Startup.TrainingOneHomeworks.Lurppis.Bank.Banks
{
    public class NarodowyBankPolski : Abstract.Bank
    {
        public NarodowyBankPolski(string bankName, int id, string name, int amount, string lastName) : base(bankName: "Narodowy Bank Polski", id: 1010, name: name, amount: amount, lastName: lastName)
        {
        }
    }
}