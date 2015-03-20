using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonFileParser
{
    public class RobsonFileEntity : FileEntityBase
    {
        public string Title { get; set; }
        public float Money { get; set; }

        public RobsonFileEntity(string name, string surname, DateTime date, string account, string title, float money)
        {
            base.Name = name;
            base.Surname = surname;
            base.Date = date;
            base.Account = account;
            this.Title = title;
            this.Money = money;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", Name, Surname, Date, Account, Title, Money);
        }

        public override string GetLine()
        {
 	        return string.Format("{0} {1} {2} {3} {4} {5}", Name, Surname, Date, Account, Title, Money);
        }
    }
}
