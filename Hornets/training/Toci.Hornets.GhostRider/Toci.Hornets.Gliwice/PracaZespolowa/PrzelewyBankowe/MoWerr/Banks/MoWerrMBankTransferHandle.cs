using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.MoWerr.Banks
{
    public class MoWerrMBankTransferHandle : TransferHandle
    {
        public MoWerrMBankTransferHandle()
        {
            BankName = "mBank";
        }

        protected override bool Send(BankTransfer transfer)
        {
            return transfer.IsTransferSuccessful = true;
        }
    }
}