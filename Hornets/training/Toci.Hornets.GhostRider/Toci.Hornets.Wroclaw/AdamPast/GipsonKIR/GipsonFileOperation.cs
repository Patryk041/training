using System.IO;
using System.Text;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.AdamPast.GipsonKIR
{
    public class GipsonFileOperation :FileOperation
    {
        public override string GetFileContent(string path)
        {

            string fileContents;
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                fileContents = streamReader.ReadToEnd();
            }

            return fileContents;
        }
    }
}