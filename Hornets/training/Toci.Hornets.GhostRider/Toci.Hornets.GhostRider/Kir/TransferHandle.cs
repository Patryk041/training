namespace Toci.Hornets.GhostRider.Kir
{
    public abstract class TransferHandle
    {
        protected string BankName;

        public bool SendTransfer(BankTransfer transfer)
        {
            return IsMyDestination(transfer) && Send(transfer);
        }

        protected abstract bool Send(BankTransfer transfer); // succesfull true lub false

        protected bool IsMyDestination(BankTransfer transfer)
        {
            return BankName == transfer.DestinationBank;
        }
    }
}