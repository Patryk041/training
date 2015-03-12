using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Clients;
using Toci.Db.Interfaces;

namespace Toci.TraininigLibrary.Developers.Dysq.Database
{
    public abstract class DysqSqlClientBase : SqlClientBase
    {
        protected DysqSqlClientBase(string name, string password, string dbAddress, string dbName) : 
            base(name, password, dbAddress, dbName)
        {

        }

       

    }
}
