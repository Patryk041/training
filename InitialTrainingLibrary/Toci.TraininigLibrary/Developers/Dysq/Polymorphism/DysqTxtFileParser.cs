using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Dysq.XML;

namespace Toci.TraininigLibrary.Developers.Dysq.Polymorphism
{
    public class DysqTxtFileParser : DysqTransferParserBase
    {
        

        public override List<DysqFileEntityPolymorphism> GetTransfers(string path)
        {
            List<DysqFileEntityPolymorphism> dysqTransfers = new List<DysqFileEntityPolymorphism>();
            
            dysqTransfers.Add(ReadRowsDysq.ReadRows(path));

            return dysqTransfers;


        }
    }
}
