using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Mg.FileParser
{
    public class MgFileDetailsParser : FileDetailParserBase{

        public override FileEntityBase ReadEntry(string fileLine)
        {
            var details = fileLine.Split(new char[] {'/'});
            MgFileEntity fileEntity = new MgFileEntity();

            var dateString = details[2].Split(new char[] {'_'});
            DateTime date = new DateTime((Convert.ToInt32(dateString[0])),(Convert.ToInt32(dateString[1])),(Convert.ToInt32(dateString[2])));
        
            Dictionary<int,Action<string>> rowFactory = new Dictionary<int, Action<string>>()
            {
                {0,(detail)=> { fileEntity.SetName(details[0]); }},
                {1,(detail)=> { fileEntity.SetSurname(details[1]); }},
                {2,(detail)=> { fileEntity.SetDate(date); }},
                {3,(detail)=> { fileEntity.SetAccount(details[3]); }},
          
            };


            for (int i = 0; i < details.Length; i++)
            {
                rowFactory[i](details[i]);
            }

            return fileEntity;


        }
    }
}
