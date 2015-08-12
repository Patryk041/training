using System.IO;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Factories;

namespace Toci.Hornets.Rzeszow.SemiRafista.KIR
{
    public class SeRaTransferHandle : TransferHandle
    {
        public SeRaTransferHandle()
        {
            BankName = "SeRaBank";
        }

        public bool SeRaSendTransfers(BankTransfer transfer)
        {
            return Send(transfer);
        }
        protected override bool Send(BankTransfer transfer)
        {
            var tr = (SeRaBankTransfer) transfer;
            using(TextWriter writer = new StreamWriter(@"F:\KURS C#\REPO\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.Rzeszow\SemiRafista\KIR\demo\SeRaRaport2.txt",true))
            {
                const string linePattern = "WYkonano przelew od: {0} do: {1} w dniu {2} na kwote {3}\n";
                writer.WriteLine(linePattern, tr.SourceClientName,tr.DestinationClientName,tr.TransferDate,tr.TransferAmount);
            }
            return true;
        }
    }
}