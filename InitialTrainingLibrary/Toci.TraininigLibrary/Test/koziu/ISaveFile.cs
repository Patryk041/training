using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Test.koziu
{
    public interface ISaveFile
    {
       bool saveFile(List<FileEntityBase> streamList);        
    }
}
