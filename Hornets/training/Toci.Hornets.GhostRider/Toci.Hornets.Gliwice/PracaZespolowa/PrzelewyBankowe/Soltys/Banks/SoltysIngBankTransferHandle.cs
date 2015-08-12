using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys.Banks
{
    public class SoltysIngBankTransferHandle : TransferHandle
    {
        public SoltysIngBankTransferHandle()
        {
            BankName = "ING";
        }

        protected override bool Send(BankTransfer transfer)
        {
            transfer.IsTransferSuccessful = true;

            return transfer.IsTransferSuccessful;
        }
    }
}
