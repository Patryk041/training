using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Dysq.FileParser
{
    public class DysqFileEntity : FileEntityBase
    {
        public void SetName(string dysqName)
        {
            Name = dysqName;
        }

        public void SetSurname(string dysqSurname)
        {
            Surname= dysqSurname;
        }

        public void SetDate(string dysqDate)
        {   
            Date = Convert.ToDateTime(dysqDate);
        }

        public void SetAccount(string dysqAccount)
        {
            Account = dysqAccount;
        }

    }
}
