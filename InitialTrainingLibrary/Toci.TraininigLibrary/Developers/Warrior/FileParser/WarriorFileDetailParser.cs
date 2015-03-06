using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Warrior.FileParser
{
    public class WarriorFileDetailParser : FileDetailParserBase
    {
        public override FileEntityBase ReadEntry(string fileLine)
        {
            // todo parse line and fill the entity
            return new WarriorFileEntity();
        }
    }
}
