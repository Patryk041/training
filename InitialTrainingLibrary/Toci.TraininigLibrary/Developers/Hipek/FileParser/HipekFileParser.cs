using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Hipek.FileParser
{
    public class HipekFileParser : FileParser<HipekFileHeaderParser, HipekFileDetailsParser, HipekFileFooterParser>
    {
        public HipekFileParser(string fileName, HipekFileDetailsParser detailsParser) : base(fileName, detailsParser)
        {
 
        }

        public override string GetName()
        {
            return "Hipek";
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
