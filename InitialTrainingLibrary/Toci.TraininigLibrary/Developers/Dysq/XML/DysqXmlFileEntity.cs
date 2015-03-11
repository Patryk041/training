using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.TraininigLibrary.Developers.Dysq.XML
{
    [XmlRoot ("transfer")]
    public class DysqXmlFileEntity
    {
        [XmlAttribute ("bank")]
        public string Bank { get; set; }

        [XmlElement ("name")]
        public string Name { get; set; }

        [XmlElement("surname")]
        public string Surname { get; set; }

        [XmlElement("sourceAccount")]
        public string SourceAccount { get; set; }

        [XmlElement("date")]
        public string DateOfTransaction { get; set; }

        [XmlElement("sum")]
        public string Amount { get; set; }

       
    }

    [XmlRoot("transfers")]
    public class DysqXmlTransfers
    {
        [XmlElement("transfer")]
        public DysqXmlFileEntity [] DysqXmlTrasfersList { get; set; }
    }
}
