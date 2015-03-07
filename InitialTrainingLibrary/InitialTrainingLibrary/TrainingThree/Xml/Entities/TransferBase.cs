using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InitialTrainingLibrary.TrainingThree.Xml.Entities
{
    [XmlRoot("transfers")]
    public class TransferBase
    {
        [XmlElement("account")]
        public string Account { get; set; }
    }
}
