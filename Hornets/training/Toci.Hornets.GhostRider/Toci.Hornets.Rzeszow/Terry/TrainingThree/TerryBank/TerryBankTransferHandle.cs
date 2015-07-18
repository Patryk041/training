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
            const string path = "..\\..\\..\\Toci.Hornets.Rzeszow\\Terry\\TrainingThree\\TerryBank\\transfers\\TerryBankAllTransfers.txt";
            var tr = (TerryBankTransfer) transfer;

            if (!transfer.IsTransferSuccessful) return false;

            using (var writer = new StreamWriter(@path, true))
            {
                writer.WriteLine("{0}.{1}.{2}.{3}.{4}.{5}.{6}.{7}.{8}/", tr.Amount, tr.DestinationBank, tr.DestinationAccountInfo.AccNr, 
                    tr.DestinationAccountInfo.OwnersName, tr.SourceBank, tr.SourceAccountInfo.AccNr, tr.SourceAccountInfo.OwnersName, tr.Title, tr.IsTransferSuccessful);

            }
            return true;
        }
    }
}