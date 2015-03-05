using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.RS.FileParser
{
    public class RsFileParser : FileParser<RsFileHeaderParser, RsFileDetailsParser, RsFileFooterParser>
    {
        private const string MyName = "Roman Suska";

        public RsFileParser(RsFileDetailsParser detailsParser) : base(detailsParser)
        {
        }

        public override string GetName()
        {
            return MyName;
        }

        public override void Dispose()
        {
            
        }
    }
}
