using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.MoWerr.Banks
{
    public class MoWerrPKOBankTransferHandle : TransferHandle
    {
        public MoWerrPKOBankTransferHandle()
        {
            BankName = "PKO";
        }

        protected override bool Send(BankTransfer transfer)
        {
            return transfer.IsTransferSuccessful = true;
        }
    }
}