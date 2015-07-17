using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys.Banks
{
    public class SoltysPkoBankTransferHandle : TransferHandle
    {
        public SoltysPkoBankTransferHandle()
        {
            BankName = "PKO";
        }

        protected override bool Send(BankTransfer transfer)
        {
            transfer.IsTransferSuccessful = true;

            return transfer.IsTransferSuccessful;
        }
    }
}
