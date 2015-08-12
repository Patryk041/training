using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi.Banki;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.PiotrekJ
{
    public class PiorekJTransferHandler : TransferHandle
    {
        public PiorekJTransferHandler()
        {
            this.BankName = "ING Bank Śląski";
        }

        protected override bool Send(BankTransfer transfer)
        {
            return IsMyDestination(transfer);
        }
    
    }
}