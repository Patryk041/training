using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Opole.OpoleKir.Banks
{
    public class PKOBPTransferHandle:TransferHandle
    {
        //XX1020XXXXXXXXXXXXXXXXXXXX
        protected override bool Send(BankTransfer transfer)
        {
            return true;
        }
    }
}