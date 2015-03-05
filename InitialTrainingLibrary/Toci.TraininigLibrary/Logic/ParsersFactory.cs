using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;
using Toci.TraininigLibrary.Developers.Domi;
using Toci.TraininigLibrary.Developers.Mg;

namespace Toci.TraininigLibrary.Logic
{
    public class ParsersFactory
    {   

        public List<FileEntityBase> GetData(string name,string path)
        {
         
          
        //FileParser<DomiFileHeader, DomiFileDetails, DomiFileFooter> abc = new DomiFileParser("a");

            Dictionary<string, Func<FileParser<FileHeaderParserBase, FileDetailParserBase, FileFooterParserBase>>> parserFactory = new Dictionary<string, Func<FileParser<FileHeaderParserBase, FileDetailParserBase, FileFooterParserBase>>>()
            {
              //  {"mg",(_path) => new MgFileParser().GetParser(path)}
              //  { "Domi", () => { return (FileParser<FileHeaderParserBase, FileDetailParserBase, FileFooterParserBase>)new DomiFileParser(); } }
            };




            return null;
        }



    }
}
