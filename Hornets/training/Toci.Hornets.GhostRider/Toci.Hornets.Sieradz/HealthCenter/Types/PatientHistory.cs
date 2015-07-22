using System.Xml.Serialization;

namespace Toci.Hornets.Sieradz.HealthCenter.Types
{
    [XmlRoot("PatientHistory")]
    public class PatientHistory
    {
        [XmlElement("Historia")]
        public string Historia { get; set; }
    }
}