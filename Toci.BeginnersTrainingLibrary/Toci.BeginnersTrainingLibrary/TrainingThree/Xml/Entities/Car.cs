using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.BeginnersTrainingLibrary.TrainingThree.Xml.Entities
{
    [XmlRoot("car")]
    public class Car
    {
//        <car name="Porsche">
//          <engine name="Boxer">TDI</engine>
//          <colour name="Metalic">Red</colour>
//  </car>
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("engine")]
        public Engine Engine { get; set; }

        [XmlElement("colour")]
        public Colour Colour { get; set; }
    }
}
