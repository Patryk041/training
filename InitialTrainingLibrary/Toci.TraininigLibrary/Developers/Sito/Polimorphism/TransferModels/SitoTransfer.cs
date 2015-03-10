using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.TraininigLibrary.Developers.Sito.Polimorphism.TransferModels
{
    [XmlRoot("transfer")]
    public class SitoTransfer
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("surname")]
        public string Surname { get; set; }
        [XmlElement("summary")]
        public string Summary { get; set; }
        [XmlElement("date")]
        public string Date { get; set; }
        [XmlElement("accountNumber")]
        public string AccountNumber { get; set; }
    }

    [XmlRoot("transfers")]
    public class SitoTransfers
    {
        [XmlElement("transfer")]
        public SitoTransfer[] SitoTransfersList
        {
            get;
            set;
        }
    }
}
