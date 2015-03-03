using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Developers.Dysq
{
    public class DysqFileParser : FileParser<DysqFileHeaderParser, DysqFileDetailParser, DysqFileFooterParser>
    {
     
        protected DysqFileDetailParser DysqDetailsParser;
        protected string DysqFileName;

        public DysqFileParser(string fileName, DysqFileDetailParser detailsParser) : base(fileName, detailsParser)
        {
            DysqFileName = fileName;
            DysqDetailsParser = detailsParser;
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
