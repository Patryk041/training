using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank
{
    public class TerryFileOperation : FileOperation
    {
        public override string GetFileContent(string path)
        {
            var reader = new StreamReader(path);
            return reader.ReadToEnd();
        }
    }
}