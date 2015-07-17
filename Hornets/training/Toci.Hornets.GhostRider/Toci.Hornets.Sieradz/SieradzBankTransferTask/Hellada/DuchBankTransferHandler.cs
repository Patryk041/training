using System.Diagnostics;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Hellada
{
    public class DuchBankTransferHandler : TransferHandle
    {
        public DuchBankTransferHandler()
        {
            BankName = "Hellada";
        }

        protected override bool Send(BankTransfer transfer)
        {
            Debug.WriteLine("Euros transfered: {0}",transfer.IsTransferSuccessful);
            return transfer.IsTransferSuccessful;
        }
    }
}