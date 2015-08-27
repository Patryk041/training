using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLlib.SQL 
{
    class SqlDriver : ISqlDriver
    {
        public DataTable[] SelectAllTables()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectTable(string TableName)
        {
            throw new NotImplementedException();
        }

        public void Insert(string[] record)
        {
            throw new NotImplementedException();
        }

        public void CreateTable(string TableName)
        {
            throw new NotImplementedException();
        }

        public DataTable ImportTable()
        {
            throw new NotImplementedException();
        }
    }
}
