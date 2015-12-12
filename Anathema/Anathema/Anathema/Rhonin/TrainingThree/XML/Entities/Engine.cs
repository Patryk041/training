using System.Xml.Serialization;

namespace Anathema.Rhonin.TrainingThree.XML.Entities
{
    //[XmlRoot("engine")]
    public class Engine
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        //[XmlElement("engine")]
        //public string Silnik { get; set; }
        [XmlText()]
        public string Silnik { get; set; }

    }
}