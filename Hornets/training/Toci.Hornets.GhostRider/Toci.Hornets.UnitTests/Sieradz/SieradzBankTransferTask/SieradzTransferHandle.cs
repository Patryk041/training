using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.UnitTests.Sieradz.SieradzBankTransferTask
{
    public abstract class SieradzTransferHandle : TransferHandle
    {
        //tutaj dodamy dictionary do łączenia numeru konta z nazwą banku
        protected override bool Send(BankTransfer transfer)
        {
            throw new System.NotImplementedException();
        }
    }
}