using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Anathema.Rhonin.TrainingThree.XML.Entities
{
    [XmlRoot("car")]
    public class Car
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("engine")]
        public Engine Engine { get; set; }

        //[XmlElement("engine")]
        //public EngineType EngineType { get; set; }


        [XmlElement("colour")]
        public Colour Colour { get; set; }
    }
}