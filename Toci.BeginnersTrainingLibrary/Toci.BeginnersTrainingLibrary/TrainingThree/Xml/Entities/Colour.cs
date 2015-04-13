using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.BeginnersTrainingLibrary.TrainingThree.Xml.Entities
{
    [XmlRoot("colour")]
    public class Colour
    {
        //<colour name="Metalic">Red</colour>
        [XmlAttribute("name")] public string TypLakieru; // { get; set; }

        [XmlElement("colour")]
        public string Kolor { get; set; }
    }
}
