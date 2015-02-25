using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InitialTrainingLibrary.syf.fileoperations.xml.entities
{
    [XmlRoot("car")]
    public class Car
    {
        [XmlElement("engine")]
        public string Engine { get; set; }

        [XmlElement("colour")]
        public string Colour { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
