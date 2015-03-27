using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonFileParser
{
    public class RobsonsFileParser : FileParser<RobsonFileHeader, RobsonFileDetails, RobsonFileFooter>
    {
        public RobsonsFileParser(RobsonFileDetails myDetails) : base(myDetails) { }

        public override string GetName()
        {
            return "Robson";
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public RobsonFileEntity UseParser(string row)
        {
            return (RobsonFileEntity)base.DetailsParser.ReadEntry(row);
        }
    }
}
