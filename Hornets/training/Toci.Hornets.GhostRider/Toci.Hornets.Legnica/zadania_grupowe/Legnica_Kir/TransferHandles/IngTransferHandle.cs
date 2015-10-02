using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Files;

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
            AlmostLikeADatebase.SaveBankTransfer((LegnicaBankTransfer)transfer);
            return true;
        }
    }
}