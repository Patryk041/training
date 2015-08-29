using System.Collections.Generic;
using Startup.TrainingOneHomeworks.lucass3231.KIR.Interfaces;


namespace Startup.TrainingOneHomeworks.lucass3231.KIR
{
    public class BankTransferManager : IBankTransferManager
    {
        public List<Interfaces.IClientTransaction> ClientTransactions { get; }
        public List<List<BankTransaction>> VerifiedClientTransactions { get; }
        public void VerifyTransfer()
        {
            throw new System.NotImplementedException();
        }

        public BankTransaction SearchAccount(string number)
        {
            throw new System.NotImplementedException();
        }
    }
}