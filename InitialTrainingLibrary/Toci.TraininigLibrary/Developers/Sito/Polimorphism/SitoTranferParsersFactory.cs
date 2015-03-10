using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Sito.Polimorphism
{
    class SitoTranferParsersFactory
    {
        private static Dictionary<string, Func<SitoTransferParserBase>> parsers = new Dictionary
            <string, Func<SitoTransferParserBase>>()
        {
            {"xml",()=>new SitoXmlTransferParser()},
            {"txt",()=>new SitoTextTransferParser()}
        };

        public static SitoTransferParserBase GetParser(string ext)
        {
            return parsers.ContainsKey(ext) ? parsers[ext]() : null;
        }
    }
}
