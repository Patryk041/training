using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Hipek.FileParser
{
    public class HipekFileDetailsParser : FileDetailParserBase
    {
        public override FileEntityBase ReadEntry(string fileLine)
        {
            HipekFileEntity row = new HipekFileEntity();

            string[] splitLine = fileLine.Split(' ');
            string[] splitDate = splitLine[2].Split('-');

            DateTime date = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]));

            row.SetName(splitLine[0]);
            row.SetSurname(splitLine[1]);
            row.SetDate(date);
            row.SetAccount(splitLine[3]);

            return row;
        }
    }
}
