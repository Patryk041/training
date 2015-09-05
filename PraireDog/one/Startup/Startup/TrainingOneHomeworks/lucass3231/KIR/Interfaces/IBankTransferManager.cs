using System.Collections.Generic;

namespace Startup.TrainingOneHomeworks.lucass3231.KIR.Interfaces
{
    public interface IBankTransferManager
    {
        List<IClientTransaction> ClientTransactions { get; }
        List<List<BankTransaction>> VerifiedClientTransactions { get; }
        void VerifyTransfer();
        BankTransaction SearchAccount(string number);  
    }
}