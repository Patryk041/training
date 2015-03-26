using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Entities
{
    public class TxtFileEntity : FileEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public string Account { get; set; }
        public string Title { get; set; }
        public float Money { get; set; }

        public TxtFileEntity(string name, string surname, DateTime date, string account, string title, float money)
        {
            Name = name;
            Surname = surname;
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
