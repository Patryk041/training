using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Alior
{
    public class UCantTouchThisTransferHandle : TransferHandle
    {
        protected override bool Send(BankTransfer transfer)
        {
            throw new System.NotImplementedException();
        }
    }
}