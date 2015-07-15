using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank
{
    public class TerryBankTransferHandle : TransferHandle
    {
        public TerryBankTransferHandle()
        {
            BankName = "TerryBank";
        }

        public bool TerrySendTransfers(BankTransfer transfer)
        {
            return Send(transfer);
        }

        protected override bool Send(BankTransfer transfer)
        {
            //zapisuje w UnitTestach bin\Debug przy testowaniu

            if (!transfer.IsTransferSuccessful) return false;

            using (var writer = new StreamWriter("TerryBankTransfersAll.txt", true))
            {
                writer.WriteLine("{0}.{1}.destNr.destName.srcNr.srcName.amount.title.{2}/", transfer.DestinationBank,
                    transfer.SourceBank, transfer.IsTransferSuccessful);

            }
            return true;
        }
    }
}