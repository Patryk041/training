using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Opole.OpoleKir.Banks
{
    public class BPHTransferHandle:TransferHandle
    {
        public BPHTransferHandle()
        {
            BankName = "BPH";//XX1060XXXXXXXXXXXXXXXX
        }

        protected override bool Send(BankTransfer transfer)
        {
            throw new System.NotImplementedException();
        }
    }
}