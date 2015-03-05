using System;
using System.Collections.Generic;
using System.Linq;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.RS.FileParser
{
    public class RsFileDetailsParser : FileDetailParserBase
    {
        public override FileEntityBase ReadEntry(string fileLine)
        {
            RsFileEntity entity = new RsFileEntity();
            var dataParts = fileLine.Split(',');

            Dictionary<string, string> myDictionary =
                dataParts.ToDictionary(s => s.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries)[0].Replace("\"", "").Replace(" ", String.Empty),
                    s => s.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("\"", "").Replace(" ", String.Empty));

            entity.SetName(myDictionary["name"]);
            entity.SetSurname(myDictionary["surname"]);
            entity.SetDate(myDictionary["datetime"]);
            entity.SetAccount(myDictionary["number"]);

            return entity;
        }
    }
}
