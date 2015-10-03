namespace Startup.TrainingOneHomeworks.Lurppis.Bank.Abstract
{
    public abstract class Bank
    {
        /*
            Zalozenia tworzymy instancje osoba
            I to ona korzysta z transakcji i opcji banku.
        */

        protected string Name { get; private set; }
        protected string LastName { get; private set; }
        // dla uproszczenia na koncie deklarujemy, ze bedzie jakas kwota
        protected int Amount { get; private set; }
        protected string BankName { get; private set; }
        protected int Id { get; private set; }

        protected Bank(string bankName, int id, string name, int amount, string lastName)
        {
            BankName = bankName;
            Id = id;
            Name = name;
            Amount = amount;
            LastName = lastName;
        }
    }
}