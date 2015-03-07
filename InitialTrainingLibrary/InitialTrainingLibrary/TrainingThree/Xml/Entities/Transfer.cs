using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InitialTrainingLibrary.TrainingThree.Xml.Entities
{
    //[XmlArray("transfer")]
    [XmlRoot("transfer")] // XMlNodeList
    public class Transfer : TransferBase
    {
        //[XmlElement("account")]
        //public string Account { get; set; }

        [XmlAttribute("bank")]
        public string Bank { get; set; }

        [XmlElement("owner")]
        public string Owner { get; set; }

        [XmlElement("sum")]
        public string Sum { get; set; }
    }

    [XmlRoot("transfers")]
    public class Transfers
    {
        [XmlElement("transfer")]
        public Transfer[] TransfersList { get; set; }
    }
}
