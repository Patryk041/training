using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir
{
    public class LegnicaFileOperation : FileOperation
    {
        public override string GetFileContent(string path)
        {
            StreamReader reader = new StreamReader(path);
            return reader.ReadToEnd();
        }
    }
}