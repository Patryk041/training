using System.Collections.Generic;
using System.Linq;

namespace Toci.TraininigLibrary.Developers.RS.XmlParser
{
    public class RsXmlTransfersParser
    {
        public List<RsTransferEntity> GetTransfersList(string path)
        {
            var myParser = new RsXmlParser<RsTransfersEntity>();
            return myParser.GetXmlData(path).TransferList.ToList();
        }
    }
}
