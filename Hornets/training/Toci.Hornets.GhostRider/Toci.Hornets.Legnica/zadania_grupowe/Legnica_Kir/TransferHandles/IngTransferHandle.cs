using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.TransferHandles
{
    public class IngTransferHandle : TransferHandle
    {
        public IngTransferHandle()
        {
            BankName = "Ing";
        }

        protected override bool Send(BankTransfer transfer)
        {
            throw new System.NotImplementedException();
        }
    }
}