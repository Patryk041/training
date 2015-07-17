using System;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys
{
    public class SoltysBankTransfer : BankTransfer
    {
        public decimal Amount { get; set; }
        public string ReceiverName { get; set; }
        public string SenderName { get; set; }
        public DateTime TransferDate { get; set; }
        public string Title { get; set; }
    }
}
