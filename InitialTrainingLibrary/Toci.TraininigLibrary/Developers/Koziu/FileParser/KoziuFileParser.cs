using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Koziu.FileParser
{
    class KoziuFileParser : FileParser<KoziuFileHeaderParser, KoziuFileDetailParser, KoziuFileFooterParserBase>
    {
        public KoziuFileParser(KoziuFileDetailParser detailsParser) : base(detailsParser)
        {
        }

        public override string GetName()
        {
            return "Koziu";
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
