using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.Interfaces;


namespace Toci.TraininigLibrary.Developers.Dysq.XMLBase
{
    public abstract class DysqTransfersParserBase : IDysqTrasfersParser
    {
        public abstract List<FileEntityBase> GetTransfers(string path);
    }
}
