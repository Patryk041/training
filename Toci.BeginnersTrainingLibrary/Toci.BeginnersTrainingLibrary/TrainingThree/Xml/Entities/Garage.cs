using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.BeginnersTrainingLibrary.TrainingThree.Xml.Entities
{
    [XmlRoot("garage")]
    [Serializable]
    public class Garage
    {
        [XmlElement("car")]
        public Car[] Cars { get; set; }
    }
}
