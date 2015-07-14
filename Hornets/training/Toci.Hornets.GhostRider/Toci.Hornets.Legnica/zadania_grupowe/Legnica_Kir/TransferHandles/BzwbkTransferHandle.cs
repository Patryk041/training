using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.TransferHandles
{
    public class BzwbkTransferHandle : TransferHandle
    {
        public BzwbkTransferHandle()
        {
            BankName = "Bzwbk";
        }

        protected override bool Send(BankTransfer transfer)
        {
            throw new System.NotImplementedException();
        }
    }
}