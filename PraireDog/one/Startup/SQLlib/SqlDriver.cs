using System;
using System.Data;
using Npgsql;
using SQLlib.SqlException;
using SQLlib.SqlInterfaces;

namespace SQLlib
{
    internal class SqlDriver : ISqlDriver
    {

        private string CreateTableSchema { get; set; }
        private ISqlConnection sqlConnection;
        public SqlDriver(ISqlConnection sqlConnection, SqlBase sqlBase)
        {
            CreateTableSchema = "Banki";
            this.sqlConnection = new SqlConnection();
            cmd.Connection = this.sqlConnection.GetConnection();
        }

        public DataTable[] SelectAllTables()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectTable(string tableName)
        {
	        return null;
        }

        public void Insert(string[] record, string tableName)
        {
            
            
        }

        public void CreateTable(string tableName)
        {
            
        }

        public DataTable ImportTable()
        {
            throw new NotImplementedException();
        }
    }
}