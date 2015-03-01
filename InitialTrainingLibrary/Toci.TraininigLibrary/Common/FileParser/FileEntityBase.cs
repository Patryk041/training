using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Common.FileParser
{
    public class FileEntityBase
    {
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public DateTime Date { get; protected set; }
        public string Account { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Name, Surname, Date, Account);
        }
    }
}
