using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SQLlib.SQL 
{
    class SqlDriver : ISqlDriver
    {
        private NpgsqlCommand cmd;
        public SqlDriver(ISqlConnection sqlConnection)
        {
            sqlConnection = new SqlConnection();
            cmd.Connection = sqlConnection.GetConnection();
            
        }
        public DataTable[] SelectAllTables()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectTable(string tableName)
        {
            cmd.CommandText = "SELECT * FROM "+tableName;
            var reader = cmd.ExecuteReader();
                
                   return reader.GetSchemaTable();
        }

        public void Insert(string[] record, string tableName)
        {
            cmd.CommandText = "INSERT INTO "+ tableName + "(ID, NumberOfAccount, NameOfBank, NumberOfBank) VALUES (1, '36249010440000420057684506', 'Alior',1111)";
            cmd.ExecuteNonQuery();
        }

        public void CreateTable(string tableName)
        {
            cmd.CommandText = "CREATE TABLE " + tableName + " {" +
                              "ID int ," +
                              "NumberOfAccount text," +
                              "NameOfBank text," +
                              "NumberOfBank int;}";
            cmd.ExecuteNonQuery();
        }

        public DataTable ImportTable()
        {
            throw new NotImplementedException();
        }
    }
}
