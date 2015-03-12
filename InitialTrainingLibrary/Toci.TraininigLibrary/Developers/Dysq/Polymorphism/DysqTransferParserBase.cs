using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.Interfaces;
using Toci.TraininigLibrary.Developers.Dysq.XML;
using Toci.TraininigLibrary.Developers.Sito.Polimorphism.Interfaces;

namespace Toci.TraininigLibrary.Developers.Dysq.Polymorphism
{
    public abstract class DysqTransferParserBase :IDysqTrasfersParser
    {
        public abstract List<DysqFileEntityPolymorphism> GetTransfers(string path);
    }
}
