using System;
using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public class SieradzFileOperation : FileOperation
    {
        public override string GetFileContent(string path)
        {
            if (!File.Exists(path)) return null; 
            try
            {
                return File.ReadAllText(path);
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}