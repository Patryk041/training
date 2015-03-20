using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonFileParser
{
    public class RobsonFileDetails :FileDetailParserBase
    {
        public override FileEntityBase ReadEntry(string fileLine)
        {
            string[] splitedString = fileLine.Split('\t');

            string name = splitedString[0];
            string surname = splitedString[1];
            DateTime date = DateTime.Parse(splitedString[2]);
            string account = splitedString[3];
            string title = splitedString[4];
            float money = float.Parse(splitedString[5]);

            return new RobsonFileEntity(name, surname, date, account, title, money);
        }
    }
}
