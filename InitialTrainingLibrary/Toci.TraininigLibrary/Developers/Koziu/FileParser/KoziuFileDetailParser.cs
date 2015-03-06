using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Koziu.FileParser
{
    class KoziuFileDetailParser : FileDetailParserBase
    {
        //private const int _size = 3; 
        public override FileEntityBase ReadEntry(string fileLine)
        {
            KoziuFileEntity entry = new KoziuFileEntity();
            string[] fields = fileLine.Split(' ');
            

            entry.SetName(fields[0]);
            entry.SetSurname(fields[1]);
            entry.SetDate((Convert.ToDateTime(fields[2])));
            entry.SetName(fields[3]);  


            return entry;
        }
    }
}
