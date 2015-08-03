using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Szary.TrainingThree
{
    public class SzaryFileOperation:FileOperation
    {
        public override string GetFileContent(string path)
        {
            var streamReader = new StreamReader(path);
            return streamReader.ReadToEnd();
        } 
    }
}