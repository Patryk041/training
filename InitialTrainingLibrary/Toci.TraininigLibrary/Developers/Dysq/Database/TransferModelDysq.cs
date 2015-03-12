using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.XML;
using Toci.TraininigLibrary.Developers.Warrior.Db.Models;

namespace Toci.TraininigLibrary.Developers.Dysq.Database
{
    public class TransferModelDysq : ModelBase
    {
        public TransferModelDysq(string tableName) : base("transfers")
        {
        }

        public int InsertData(DysqFileEntityPolymorphism record)
        {
            if (record != null)
            {
                string query = "Insert into " + TableName +
                               "(bank, name, surname, sourceAccount, dateOfTransaction, sum) values ('" + record.Bank +
                               "','" + record.Name + "', '" +
                               record.Surname + "', '" + record.SourceAccount + "', '" + record.DateOfTransaction +
                               "', '" + record.Amount + "');";

                return client.SetData(query);
            }

            return 0;
        }

        public DataSet GetData()
        {
          
                string query = "select bank, name, surname, sourceAccount, dateOfTransaction, sum from " + TableName +
                               ";";

                return client.GetData(query);

        }
    }
}
