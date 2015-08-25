using System.Collections.Generic;
using Startup.TrainingOneHomeworks.GroupMati.Banks;
using Startup.TrainingOneHomeworks.Mati.InterfaceBanks;

namespace Startup.TrainingOneHomeworks.Mati.Banks
{
    public class FabricBankTransaction : IFabricBankTransaction
    {
        public ClientTransaction CreateClient()
        {
            return new ClientTransaction();
        }

        public BankTransactionMenager CrateBankTransactionMenager()
        {
            return new BankTransactionMenager();
        }

        public Dictionary<string, BankTransaction> CreateDictionaryBank()
        {
            return new Dictionary<string, BankTransaction>()
        {
            {"1111", new AliorTransactionBank() },
           //  {"1112", new BgzTransactionBank() }
        };
        }
    }
}