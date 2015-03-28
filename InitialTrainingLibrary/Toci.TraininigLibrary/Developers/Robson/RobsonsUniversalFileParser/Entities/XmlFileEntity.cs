using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Entities
{
    //[XmlRoot("transfer")]
    public class XmlFileEntity : FileEntity
    {
        //[XmlElement("name")]
        public string Name { get; set; }

        //[XmlElement("surname")]
        public string Surname { get; set; }

        //[XmlElement("date")]
        public DateTime Date { get; set; }

        //[XmlElement("account")]
        public string Account { get; set; }

        //[XmlElement("title")]
        public string Title { get; set; }

        //[XmlElement("money")]
        public float Money { get; set; }
        

        public XmlFileEntity(string name, string surName, DateTime date, string account, string title, float money)
        {
            Name = name;
            Surname = surName;
            Date = date;
            Account = account;
            Title = title;
            Money = money;
        }
        public override string GetLine()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", Name, Surname, Date, Account, Title, Money);
        }
    }
}
