using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InitialTrainingLibrary.syf.fileoperations.xml.entities
{
    [XmlRoot("garage")]
    public class Garage
    {
        //[XmlArray("cars")]
        //[XmlArrayItem("car")]
        [XmlElement("car")]
        public Car[] Cars { get; set; }
    }
}
