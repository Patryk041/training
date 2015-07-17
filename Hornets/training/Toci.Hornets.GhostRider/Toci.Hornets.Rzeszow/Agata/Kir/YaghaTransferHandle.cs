using System.IO;
using System.Text;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Agata.Kir
{
    public class YaghaTransferHandle : Toci.Hornets.GhostRider.Kir.TransferHandle
    {
        protected override bool Send(BankTransfer transfer)
        {
            string path = @"C:\aga\03_TOCI\01_TOCI_HORNETS\Repo\training\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.Rzeszow\Agata\Kir\BankTransferFiles\YaghaTransfersResult.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            var message = new StringBuilder("Przelerw nr " + ((YaghaBankTransfer)transfer).TransferNumber + " zostal wykonany");
            TextWriter executeTransfer = new StreamWriter(path);
            executeTransfer.WriteLine(message);
            executeTransfer.Close();
            return true;
        }
    }
}