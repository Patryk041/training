using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Dysq.XML;
using Toci.TraininigLibrary.Developers.Dysq.XMLBase;

namespace Toci.TraininigLibrary.Developers.Dysq.Polymorphism
{
    public class DysqTxtFileParser : DysqTransfersParserBase
    {
        

        public override List<DysqFileEntityPolymorphism> GetTransfers(string path)
        {

            List<DysqFileEntityPolymorphism> dysqTransfers = new List<DysqFileEntityPolymorphism>();
            
            dysqTransfers.Add(ReadRowsDysq.ReadRows(path));

             return dysqTransfers;

        }
    }
}
