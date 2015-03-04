using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Dysq.FileParser
{
    public class DysqFileDetailParser : FileDetailParserBase
    {
        
        public override FileEntityBase ReadEntry(string fileLine)
        {
            DysqFileEntity entity = new DysqFileEntity();

           var fields = fileLine.Split(new[] {"-"}, StringSplitOptions.None);

            entity.SetName(fields[0]);
            entity.SetSurname(fields[1]);
            entity.SetDate(fields[2]);
            entity.SetAccount(fields[3]);


            return entity;
        }


    }
}
