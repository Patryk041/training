using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Opole.OpoleKir.Banks
{
    public class INGTransferHandle:TransferHandle
    {
        //XX1050XXXXXXXXXXXXXXXXXXXX
        protected override bool Send(BankTransfer transfer)
        {
            return true;
        }
    }
}