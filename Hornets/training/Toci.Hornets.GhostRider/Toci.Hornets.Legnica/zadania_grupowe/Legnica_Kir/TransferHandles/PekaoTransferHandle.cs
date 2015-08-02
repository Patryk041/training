using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Files;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.TransferHandles
{
    public class PekaoTransferHandle : TransferHandle
    {
        public PekaoTransferHandle()
        {
            BankName = "Pekao";
        }

        protected override bool Send(BankTransfer transfer)
        {
            AlmostLikeADatebase.SaveBankTransfer((LegnicaBankTransfer)transfer);
            return true;
        }
    }
}