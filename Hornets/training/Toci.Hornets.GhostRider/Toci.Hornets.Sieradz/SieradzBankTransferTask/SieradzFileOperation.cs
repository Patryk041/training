using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public class SieradzFileOperation : FileOperation
    {
        public override string GetFileContent(string path)
        {
            return File.Exists(path) ? File.ReadAllText(path) : null;
        }
    }
}