using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Sito.FileParser
{
    public class SitoDetailsParser:FileDetailParserBase
    {
        public override FileEntityBase ReadEntry(string fileLine)
        {
            var details = fileLine.Split('|');
            var fileEntity = new SitoFileEntity();

            fileEntity.SetName(details[0]);
            fileEntity.SetSurname(details[1]);
            fileEntity.SetDate(Convert.ToDateTime(details[2]));
            fileEntity.SetAccount(details[3]);

            return fileEntity;



        }
    }
}
