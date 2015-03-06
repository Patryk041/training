using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Koziu.FileParser
{
    public class KoziuFileEntity : FileEntityBase
    {
        
        public override string GetLine()
        {
            return string.Format("Name: {0} Surname: {1} Date: {2} Account: {3}", Name, Surname, Date.ToShortDateString(), Account);
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetSurname(string surname)
        {
            Surname = surname;
        }

        public void SetDate(DateTime date)
        {
           Date = date;
        }

        public void SetAccount(string account)
        {
            Account = account;
        }
    }
}
