using System.Collections.Generic;

namespace Startup.TrainingOneHomeworks.Mati.InterfaceBanks
{
    public interface IBankTransactionFactory
    {
        bool TryGetTransaction(string key, out BankTransaction bankTransaction);
        
    }
}