using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.FileParser;

namespace Toci.TraininigLibrary.Developers.Dysq.Interfaces
{
    public interface IDysqTrasfersParser
    {
        List<FileEntityBase> GetTransfers(string path);
    }
}
