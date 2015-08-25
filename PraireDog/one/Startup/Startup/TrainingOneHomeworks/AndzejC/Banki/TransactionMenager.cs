using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace Startup.TrainingOneHomeworks.AndzejC.Banki
{
    public class TransactionMenager
    {
        protected List<Transaction> TransferList;
        readonly BankList2 _banks = new BankList2();
        public void SendTransfers()
        {
            foreach (var item in TransferList)
            {
                //sender
                _banks.GetElement(item.SenderAccNumber.Substring(2, 4)).SendTransfer();
                //receiver
                _banks.GetElement(item.ReceiverAccNumber.Substring(2, 4)).SendTransfer();

            }
        }
      
        
    }


}