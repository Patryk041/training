using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Chojnecki.Kir
{
    public class AndrzejFileOperation : FileOperation
    {
        public override string GetFileContent(string path)
        {
            var file = new StreamReader(path);
            var text = file.ReadToEnd();
            file.Close();
            return text;
        }
    }
}