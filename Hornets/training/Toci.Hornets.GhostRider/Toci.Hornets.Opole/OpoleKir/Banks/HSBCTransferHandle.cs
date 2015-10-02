using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Opole.OpoleKir.Banks
{
    public class HSBCTransferHandle:TransferHandle
    {
        public HSBCTransferHandle()
        {
            BankName = "HSBC";// XX1280XXXXXXXXXXXXXXXX
        }

        protected override bool Send(BankTransfer transfer)
        {
            throw new System.NotImplementedException();
        } 
    }
}