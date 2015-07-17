using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.Foonesh.TrainingThree
{
    class FileOperationFoonesh:FileOperation
    {
        public override string GetFileContent(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            return streamReader.ReadToEnd();
        }
    }
}
