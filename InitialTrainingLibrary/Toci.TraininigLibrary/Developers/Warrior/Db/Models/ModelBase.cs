using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Clients;
using Toci.Db.Interfaces;

namespace Toci.TraininigLibrary.Developers.Warrior.Db.Models
{
    public abstract class ModelBase
    {
        protected IDbClient client = new PostgreSqlClient("postgres", "beatka", "localhost", "postgres");
        protected string TableName;

        protected ModelBase(string tableName)
        {
            TableName = tableName;
        }
    }
}
