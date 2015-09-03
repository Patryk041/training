using System.Collections.Generic;
using Startup.TrainingOneHomeworks.lucass3231.KIR.Interfaces;

namespace Startup.TrainingOneHomeworks.lucass3231.KIR
{
    public class ClientTransaction : IClientTransaction
    {
       
        public string IncomingNumber { get; set; }
        public string OutcomingNumber { get; set; }
        public List<BankTransaction> GetTransactions(BankTransaction bankTransaction)
        {
            throw new System.NotImplementedException();
        }
    }
}