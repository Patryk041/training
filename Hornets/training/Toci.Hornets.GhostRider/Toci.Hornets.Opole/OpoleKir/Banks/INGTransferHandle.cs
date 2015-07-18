using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Opole.OpoleKir.Banks
{
    public class INGTransferHandle:TransferHandle
    {
        public INGTransferHandle()
        {
            BankName = "ING";// XX1050XXXXXXXXXXXXXXXX
        }

        protected override bool Send(BankTransfer transfer)
        {
            throw new System.NotImplementedException();
        }
    }
}