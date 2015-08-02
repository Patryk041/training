using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.TransferHandles
{
    public class NordeaTransferHandle : TransferHandle
    {
        public NordeaTransferHandle()
        {
            BankName = "Nordea";
        }

        protected override bool Send(BankTransfer transfer)
        {
            throw new System.NotImplementedException();
        }
    }
}