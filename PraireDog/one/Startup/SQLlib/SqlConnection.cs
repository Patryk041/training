using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SQLlib.SQL;

namespace SQLlib
{
    public class SqlConnection : ISqlConnection
    {
        private NpgsqlConnection connection;
        public SqlConnection()
        {
            
        }

        public void SetConnection(string host)
        {
            throw new NotImplementedException();
        }

        public void SetConnection(string host, string port)
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            throw new SqlExceptions("Error");
        }

        public bool CheckConnection()
        {
            throw new NotImplementedException();
        }
    }
}
