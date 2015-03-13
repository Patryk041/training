using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.Clients
{
    public class MsSqlClient : SqlClientBase
    {
        public MsSqlClient(string name, string password, string dbAddress, string dbName) : base(name, password, dbAddress, dbName)
        {
        }

        public override DataSet GetData(string query)
        {
            throw new NotImplementedException();
        }

        public override int SetData(string query)
        {
            throw new NotImplementedException();
        }
    }
}
