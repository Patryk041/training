using System.Xml.Serialization;

namespace Anathema.Rhonin.TrainingThree.XML.Entities
{
    [XmlRoot("garage")]
    public class Garage
    {
         [XmlElement("car")]
         public Car[] Cars { get; set; }

       
    }
}