using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Mg.FileParser;
using Toci.TraininigLibrary.Developers.RS.FileParser;
using Toci.TraininigLibrary.Developers.Sito.FileParser;

namespace Toci.TraininigLibrary.Developers.Sito.Polimorphism
{
    public class TextParserFactory
    {
        private static Dictionary<string, Func<FileDetailParserBase>> parsers = new Dictionary
            <string, Func<FileDetailParserBase>>()
        {
            {"sito",()=>new SitoDetailsParser()},
            {"rs",()=> new RsFileDetailsParser()},
            {"mg",()=> new MgFileDetailsParser()},
        };
        public static FileDetailParserBase GetParser(string devName)
        {
            return parsers[devName]();
        }
    }
}
