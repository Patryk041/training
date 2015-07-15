using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Opole.OpoleKir.Banks
{
    public class mBankTransferHandle:TransferHandle
    {
        //XX1140XXXXXXXXXXXXXXXXXXXX 
        protected override bool Send(BankTransfer transfer)
        {
            return true;
        }
    }
}