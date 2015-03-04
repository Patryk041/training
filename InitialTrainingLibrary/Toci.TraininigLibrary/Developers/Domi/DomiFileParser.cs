using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Domi
{
    class DomiFileParser : FileParser<DomiFileHeader, DomiFileDetails, DomiFileFooter>
    {
        public DomiFileParser(string fileName) : base(fileName, new DomiFileDetails())
        {
            
        }

        public override string GetName()
        {
            return FileName; 
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
