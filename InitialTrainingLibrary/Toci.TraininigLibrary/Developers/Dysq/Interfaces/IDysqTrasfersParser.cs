using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.XML;

namespace Toci.TraininigLibrary.Developers.Dysq.Interfaces
{
    public interface IDysqTransfersParser
    {
        List<DysqFileEntityPolymorphism> GetTransfers(string path);
    }
}
