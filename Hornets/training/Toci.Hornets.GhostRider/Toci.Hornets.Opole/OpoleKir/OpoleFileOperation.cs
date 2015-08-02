using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Opole.OpoleKir
{
    public class OpoleFileOperation:FileOperation
    {
        public override string GetFileContent(string path)
        {
            return File.Exists(path) ? File.ReadAllText(path) : null;
        }
    }
}