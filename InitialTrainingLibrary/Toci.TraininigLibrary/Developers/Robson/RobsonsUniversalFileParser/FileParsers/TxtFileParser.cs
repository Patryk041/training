using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Entities;
using Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.FileParsers
{
    public class TxtFileParser : FileParser
    {
        public override List<IParsable> GetParsedData(string filePath)
        {
            List<IParsable> parsedContent = new List<IParsable>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] splitedString = reader.ReadLine().Split('\t');

                    string name = splitedString[0];
                    string surname = splitedString[1];
                    DateTime date = DateTime.Parse(splitedString[2]);
                    string account = splitedString[3];
                    string title = splitedString[4];
                    float money = float.Parse(splitedString[5]);

                    parsedContent.Add(new TxtFileEntity(name, surname, date, account, title, money));
                }
            }
            return parsedContent;
        }
    }
}
