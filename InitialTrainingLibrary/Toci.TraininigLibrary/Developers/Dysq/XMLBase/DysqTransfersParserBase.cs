using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.Interfaces;
using Toci.TraininigLibrary.Developers.Dysq.XML;


namespace Toci.TraininigLibrary.Developers.Dysq.XMLBase
{
    public abstract class DysqTransfersParserBase : IDysqTrasfersParser
    {
        public abstract List<DysqFileEntityPolymorphism> GetTransfers(string path);
    }
}
