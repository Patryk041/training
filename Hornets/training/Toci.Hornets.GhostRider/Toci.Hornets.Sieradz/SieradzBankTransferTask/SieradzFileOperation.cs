using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public class SieradzFileOperation : FileOperation
    {
        public override string GetFileContent(string path)
        {
            FileStream loadedFile = new FileStream(path, FileMode.Open);
            //return loadedFile.Read(new byte[loadedFile.Length], 0, int.MaxValue).ToString();
            return loadedFile.ToString();
        }
    }
}