using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.TraininigLibrary.Developers.RS.XmlParser
{
    [XmlRoot("transfer")]
    public class RsTransferEntity
    {
        [XmlAttribute("bank")]
        public string BankName { get; set; }

        [XmlElement("account")]
        public string AccountNumber { get; set; }

        [XmlElement("owner")]
        public string Owner { get; set; }

        [XmlElement("sum")]
        public string Sum { get; set; }

        [XmlElement("sourceAccount")]
        public string SourceAccountNumber { get; set; }

        [XmlElement("date")]
        public string Date { get; set; }
    }

    [XmlRoot("transfers")]
    public class RsTransfersEntity
    {
        [XmlElement("transfer")]
        public RsTransferEntity[] TransferList { get; set; }
    }
}
