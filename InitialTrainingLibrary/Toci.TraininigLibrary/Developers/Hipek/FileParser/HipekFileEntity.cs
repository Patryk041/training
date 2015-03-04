using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Hipek.FileParser
{
    public class HipekFileEntity : FileEntityBase
    {
        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetSurname(string surname)
        {
            this.Surname = surname;
        }

        public void SetDate(DateTime date)
        {
            this.Date = date;
        }

        public void SetAccount(string account)
        {
            this.Account = account;
        }
    }
}
