using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.BeginnersTrainingLibrary.TrainingThree.Xml.Entities
{
    [XmlRoot("engine")]
    public class Engine
    {
        //<engine name="Boxer">TDI</engine>
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("engine")]
        public string Silnik { get; set; }
    }
}
