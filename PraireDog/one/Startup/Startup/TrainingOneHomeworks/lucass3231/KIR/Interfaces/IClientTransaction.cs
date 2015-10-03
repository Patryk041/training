using System.Collections.Generic;

namespace Startup.TrainingOneHomeworks.lucass3231.KIR.Interfaces
{
    public interface IClientTransaction
    {
        string IncomingNumber { get; set; }
        string OutcomingNumber { get; set; }
        List<BankTransaction> GetTransactions(BankTransaction bankTransaction);
    }
}