using System.Collections.Generic;

namespace Startup.TrainingOneHomeworks.Mati.InterfaceBanks
{
    public interface IFabricBankTransaction
    {
        ClientTransaction CreateClient();
        BankTransactionMenager CrateBankTransactionMenager();

        Dictionary<string, BankTransaction> CreateDictionaryBank();
    }
}