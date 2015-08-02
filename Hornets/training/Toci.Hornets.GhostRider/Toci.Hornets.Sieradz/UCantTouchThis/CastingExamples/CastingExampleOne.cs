using System.Runtime.InteropServices.ComTypes;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Sieradz.SieradzBankTransferTask;

namespace Toci.Hornets.Sieradz.UCantTouchThis.CastingExamples
{
    public class CastingExampleOne
    {
        public double ExampleOne()
        {
            var one = new One();
            var two = new Two();

            one = one as Two;
            one = one as One;
            //            two = two as One;     // Not gonna happen

            One var1 = new Two();
            return ((Two) var1).Three;

        }

        public SieradzBankTransfer ExampleTwo()
        {
            BankTransfer transfer = new SieradzBankTransfer();
            transfer = FillTransfer(transfer);
            transfer = FillSieradzTransfer(transfer);

            return transfer as SieradzBankTransfer;
        }

        public BankTransfer FillTransfer(BankTransfer transfer)
        {
            transfer.DestinationBank = "destination";
            transfer.SourceBank = "source";
            return transfer;
        }

        public BankTransfer FillSieradzTransfer(BankTransfer transfer)
        {
            (transfer as SieradzBankTransfer).TransferInfo.Amount = "mnóstwo";
            return transfer;
        }
    }
}