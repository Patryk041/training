using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.UnitTests.Sieradz.SieradzBankTransferTask
{
    public class SieradzFileOperation : FileOperation
    {
        public override string GetFileContent(string path)
        {
            FileStream loadedFile = new FileStream(path, FileMode.Open);
            return loadedFile.ToString();

        }
    }
}