using System;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.MoWerr
{
    public class MoWerrBankTransfer : BankTransfer
    {
        public string SenderName { get; set; }
        public string ReciverName { get; set; }
        public float Amount { get; set; }
        public DateTime TransferDate { get; set; }
        public string Title { get; set; }
    }
}