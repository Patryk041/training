using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;
using Toci.TraininigLibrary.Developers.Domi;
using Toci.TraininigLibrary.Developers.Dysq.FileParser;
using Toci.TraininigLibrary.Developers.Hipek.FileParser;
using Toci.TraininigLibrary.Developers.Koziu.FileParser;
using Toci.TraininigLibrary.Developers.Mg;
using Toci.TraininigLibrary.Developers.RS.FileParser;
using Toci.TraininigLibrary.Developers.Santi.FileParser;
using Toci.TraininigLibrary.Developers.Warrior.FileParser;

namespace Toci.TraininigLibrary.Logic
{
    class ParsersFactory
    {

 
        public FileDetailParserBase GetProperParser(string name)
        {
            Dictionary<string, Func<FileDetailParserBase>> parserFactory = new Dictionary<string, Func<FileDetailParserBase>>()
            {
              //  {"mg",(_path) => new MgFileParser().GetParser(path)}
              //  { "Domi", () => { return (FileParser<FileHeaderParserBase, FileDetailParserBase, FileFooterParserBase>)new DomiFileParser(); } }
                { "DOMI", () => new DomiFileDetails()},
                { "SANTI", () => new SantiFileDetailParser()},
                { "RS", () => new RsFileDetailsParser()},
                { "MG", () => new MgFileParser()},
                { "HIPEK", () => new HipekFileDetailsParser()},
                { "DYSQ", () => new DysqFileDetailParser()},
                { "KOZIU", () => new KoziuFileDetailParser()},
                { "WARRIOR", () => new WarriorFileDetailParser()},
                { "SITO", () => new WarriorFileDetailParser()},
               
            };

            //return parserFactory[path.GetName()]();
           return parserFactory[name]();
        }

    }
}
