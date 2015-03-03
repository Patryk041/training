using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Domi
{
    public class DomiFileDetails : FileDetailParserBase
    {

        private string _fileLine;

        public DomiFileDetails()
        { }
        public DomiFileDetails(string fileLine)
        {
            this._fileLine = fileLine;
        }

       
        public override FileEntityBase ReadEntry(string fileLine)
        {
            DomiFileEntity ReturnData = new DomiFileEntity();
            
            this._fileLine = fileLine; //możliwe że to jes tu nie potrzebne, lub potrzebne i nie potrzebny konstruktor

            _fileLine = _fileLine.Trim();
            List<string> _splitFile = _fileLine.Split(';').ToList();
            
             ReturnData.GetName( _splitFile[0]);
             ReturnData.GetSurname(_splitFile[1]);
             ReturnData.GetDate(_splitFile[2]);
             ReturnData.GetAccount(_splitFile[3]);

            return ReturnData; 
        }

    }
}
