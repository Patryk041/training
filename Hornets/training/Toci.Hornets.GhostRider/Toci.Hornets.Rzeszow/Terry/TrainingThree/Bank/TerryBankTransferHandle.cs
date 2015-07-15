using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.Bank
{
    public class TerryBankTransferHandle : TransferHandle
    {
        protected override bool Send(BankTransfer transfer)
        {
            return true;

        }
    }
}