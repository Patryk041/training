using System.Xml.Serialization;

namespace Toci.Hornets.Sieradz.HealthCenter.Types
{
    [XmlRoot("PersonalData")]
    public class PersonalData
    {
        [XmlElement("Wiek")]
        public int Wiek { get; set; }
    }
}