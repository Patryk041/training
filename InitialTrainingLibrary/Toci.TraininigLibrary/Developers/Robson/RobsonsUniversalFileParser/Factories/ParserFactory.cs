using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.FileParsers;
using Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Factories
{
    public class ParserFactory
    {
        public IReadable GetRightParser(string filePath)
        {
            string fileExtension = filePath.Substring(filePath.Length - 3, 3);

            Dictionary<string, Func<IReadable>> parserDictionary = new Dictionary<string, Func<IReadable>>
            {
                {"txt", ()=> new TxtFileParser()},
                {"xml", ()=> new XmlFileParser()}
            };

            return parserDictionary[fileExtension]();
        }
    }
}
