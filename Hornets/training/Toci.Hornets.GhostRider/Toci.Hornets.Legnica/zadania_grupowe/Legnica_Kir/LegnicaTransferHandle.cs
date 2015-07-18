using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir
{
    public abstract class LegnicaTransferHandle
    {
        public string BankName{ get; private set; }

        public bool SendTransfer(BankTransfer transfer)
        {
            return Send(transfer);
        }

        protected abstract bool Send(BankTransfer transfer); // succesfull true lub false       
    }
}