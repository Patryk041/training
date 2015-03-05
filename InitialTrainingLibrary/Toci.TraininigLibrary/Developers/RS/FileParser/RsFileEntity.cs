using System;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.RS.FileParser
{
    public class RsFileEntity : FileEntityBase
    {
        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetSurname(string surname)
        {
            this.Surname = surname;
        }

        public void SetDate(string date)
        {
            this.Date = Convert.ToDateTime(date);
        }

        public void SetAccount(string account)
        {
            this.Account = account;
        }
    }
}
