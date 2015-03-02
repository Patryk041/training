using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Common.FileParser
{
    public abstract class FileDetailParserBase : IFileSection
    {
        public abstract FileEntityBase ReadEntry(string fileLine);

    }
}
