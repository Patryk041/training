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
        public DomiFileParser() : base(new DomiFileDetails())
        {
            
        }

        public override string GetName()
        {
            return "Domi"; 
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
