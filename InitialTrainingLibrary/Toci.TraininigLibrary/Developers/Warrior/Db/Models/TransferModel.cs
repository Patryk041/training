using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Warrior.Db.Models
{
    public class TransferModel : ModelBase
    {
        public TransferModel() : base("transfers")
        {
            
        }

        public int Insert(FileEntityBase record)
        {
            if (record != null)
            {
                string query = "insert into " + TableName + "(name, surname, date, account) values ('" + record.Name +
                               "', '" + record.Surname + "', '" + record.Date + "', '" + record.Account + "');";

                return client.SetData(query);
            }

            return 0;
        }
    }
}
