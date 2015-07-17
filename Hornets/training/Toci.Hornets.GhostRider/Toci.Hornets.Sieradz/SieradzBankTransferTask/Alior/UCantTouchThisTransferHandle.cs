using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Alior
{
    public class UCantTouchThisTransferHandle : TransferHandle
    {

        public UCantTouchThisTransferHandle()
        {
            BankName = "Alior";
        }

        protected override bool Send(BankTransfer transfer)
        {
            transfer.IsTransferSuccessful = true;
            return true;
        }
    }
}