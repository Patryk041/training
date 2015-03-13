using System.Xml.Serialization;

namespace Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers
{
    [XmlRoot("transfer")]
    public class MgXmlEntity
    {

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("surname")]
        public string Surname { get; set; }

        [XmlElement("account")]
        public string Account { get; set; }

        [XmlElement("date")]
        public string Date { get; set; }

    }

    [XmlRoot("transfers")]
    public class MgXmlEntities
    {
        [XmlElement("transfer")]
        public MgXmlEntity[] MgXmlEntitiesList { get; set; }
    }

}
