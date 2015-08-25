using System;
using Startup.TrainingOneHomeworks.Mati;
using Startup.TrainingOneHomeworks.Mati.InterfaceBanks;
using Startup.TrainingOneHomeworks.Mati.Messages;

namespace Startup.TrainingOneHomeworks.GroupMati.Banks
{
    public class AliorTransactionBank : BankTransaction
    {
        public AliorTransactionBank():base("Alior Bank")
        {
            
        }


        public void DescriptionTransaction()
        {
            base.DescriptionTransaction();
        }

        public string GetBankName(string name)
        { 
            return BankName;
        }


        public override void IncommingTransaction()
        {
            throw new NotImplementedException();
        }

        public override void OutCommingTransaction()
        {
            throw new NotImplementedException();
        }
    }
}