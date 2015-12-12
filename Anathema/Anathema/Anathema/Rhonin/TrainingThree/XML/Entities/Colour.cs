using System.Xml.Schema;
using System.Xml.Serialization;

namespace Anathema.Rhonin.TrainingThree.XML.Entities
{
    [XmlRoot("colour")]
    public class Colour
    {
        [XmlAttribute("name")]
        public string Type { get; set; }

        [XmlElement("colour")]
        public string Kolor { get; set; }
    }
}