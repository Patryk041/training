using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Domi
{
    class DomiFileParser : FileParser<DomiFileHeader, DomiFileDetails, DomiFileFooter>
    {
        private FileEntityBase readRowe; 
        public DomiFileParser(string fileName) : base(fileName)
        {
        }

        protected override FileEntityBase ReadRow()
        {
            return readRowe; 
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
