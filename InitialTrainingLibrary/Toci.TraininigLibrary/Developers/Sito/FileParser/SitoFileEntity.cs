using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Sito.FileParser
{
    public class SitoFileEntity:FileEntityBase
    {

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetAccount(string accountNumber)
        {
            this.Account = accountNumber;
        }

        public void SetSurname(string surname)
        {
            this.Surname = surname;
        }

        public void SetDate(DateTime date)
        {
            this.Date = date;
        }
    }
}
