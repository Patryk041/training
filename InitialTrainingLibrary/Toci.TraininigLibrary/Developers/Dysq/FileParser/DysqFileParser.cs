using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Developers.Dysq.FileParser
{
    public class DysqFileParser : FileParser<DysqFileHeaderParser, DysqFileDetailParser, DysqFileFooterParser>
    {
        public DysqFileParser(string fileName, DysqFileDetailParser detailsParser) : base(fileName, detailsParser)
        {
            
        }

        

        public override string GetName()
        {
            return "Dysq";
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
