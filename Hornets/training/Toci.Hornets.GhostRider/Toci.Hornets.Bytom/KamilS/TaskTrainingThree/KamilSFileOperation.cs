using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;
using System.IO;

namespace Toci.Hornets.Bytom.KamilS.TaskTrainingThree
{
    class KamilSFileOperation : FileOperation
    {
        public override string GetFileContent(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            return streamReader.ReadToEnd();
        }
    }
}
