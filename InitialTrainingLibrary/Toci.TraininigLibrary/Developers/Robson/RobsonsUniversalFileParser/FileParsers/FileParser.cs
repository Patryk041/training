using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.FileParsers
{
    public abstract class FileParser : IReadable
    {
        public abstract List<IParsable> GetParsedData(string filePath);
    }
}
