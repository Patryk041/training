using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Sito.Polimorphism.TransferModels;

namespace Toci.TraininigLibrary.Developers.Sito.Polimorphism
{
    class SitoXmlTransferParser:SitoTransferParserBase
    {

        public override List<SitoTransfer> GetTransfers(string path)
        {
            XmlParser<SitoTransfers> xmlParser = new XmlParser<SitoTransfers>();
            var result = xmlParser.GetXmlData(path);

            return result.SitoTransfersList.ToList();
        
        }
    }
}
