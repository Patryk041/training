using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Factories;
using Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser
{
    public class RobsonsUniversalFileParser
    {
        public List<IParsable> ParseFile(string filePath)
        {
            List<IParsable> transfers = new List<IParsable>();

            ParserFactory factory = new ParserFactory();

            transfers = factory.GetRightParser(filePath).GetParsedData(filePath);

            return transfers;
        }
    }
}
