using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Sito.FileParser
{
    class SitoFileParser : FileParser<SitoHeaderParser,SitoDetailsParser,SitoFooterParser>
    {
        public SitoFileParser(SitoDetailsParser detailsParser) : base(detailsParser)
        {
        }

        public override string GetName()
        {
            return "Sito";
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
