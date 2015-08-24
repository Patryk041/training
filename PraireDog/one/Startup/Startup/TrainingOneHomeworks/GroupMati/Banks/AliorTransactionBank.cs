using System;
using System.Linq;

namespace Startup.TrainingOneHomeworks.Mati.Banks
{
    public class AliorTransactionBank : BankTransaction
    {
        public AliorTransactionBank():base("Alior Bank")
        {
            
        }
        public override void IncommingTransaction()
        {
            throw new NotImplementedException();
            
        }

        public override void OutCommingTransaction()
        {
            throw new NotImplementedException();
        }

        public override void DescriptionTransaction()
        {
            base.DescriptionTransaction();
        }

        public override string GetBankName(string name)
        { 
            return BankName;
        }
    }
}