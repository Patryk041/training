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

            // Remove curly brackets
            fileLine = fileLine.Replace("{", "").Replace("}", "");

            // Split data parts
            var dataParts = fileLine.Split(',');

            Dictionary<string, string> myDictionary =
                dataParts.ToDictionary(KeySelector, ValueSelector);

            entity.SetName(myDictionary["name"]);
            entity.SetSurname(myDictionary["surname"]);
            entity.SetDate(myDictionary["datetime"]);
            entity.SetAccount(myDictionary["number"]);

            return entity;
        }

        private string KeySelector(string textLine)
        {
            string keyText = textLine.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries)[0];

            // Remove double quotes
            keyText = keyText.Replace("\"", "");

            // Remove spaces
            keyText = keyText.Replace(" ", String.Empty);

            return keyText;
        }

        private string ValueSelector(string textLine)
        {
            string keyText = textLine.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)[1];

            // Remove double quotes
            keyText = keyText.Replace("\"", "");

            // Remove spaces
            keyText = keyText.Replace(" ", String.Empty);

            return keyText;
        }
    }
}
