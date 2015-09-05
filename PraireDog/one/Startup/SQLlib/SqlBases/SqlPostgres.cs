using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;
using SQLlib.SqlException;
using SQLlib.SqlInterfaces;

namespace SQLlib.SqlBases
{
	public class SqlPostgres : SqlBase 

	{
        
	    private const string INSERTCOMMANDPATTERN = "INSTERT INTO \"{0} \".\"{1}\"({2}) VALUES ({3})";
	    private const string SELECTCOMMANDPATTERN = "SELECT {0} FROM \" {1}\".\"{2}\"";
        private const string CREATECOMMANDPATTERN = "CREATE TABLE \" {0} \".\" {1} \" ({2})";
	    private const string DROPCOMMANDPATTERN = "DROP TABLE {0}";
	    private NpgsqlConnection connection;
        private readonly NpgsqlCommand cmd = new NpgsqlCommand();
	    public override string SchemaName { get; set; }


        public SqlPostgres() : base()
        {
        }

	    public override void SqlConnection(IPropertiesConnection propertiesConnection,
            ISqlConnection<ISqlBase> sqlConnection)
        {
            connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=programowanie;Database=Banki");
            this.sqlConnection = sqlConnection;
            SchemaName = propertiesConnection.Schema;
            try
            {
                connection = new NpgsqlConnection(
                    "Host=" + propertiesConnection.Host +
                    ";Username=" + propertiesConnection.User +
                    ";Password=" + propertiesConnection.Password +
                    ";Database=" + propertiesConnection.DBname);
            }
            catch (NpgsqlException ex)
            {
                throw new SqlExceptions(ex.Message);
            }
            finally
            {
                sqlConnection.CloseConnection();
            }
        }

	   

	    public override DataTable[] SelectAllTables(Dictionary<string, List<string>> tables)
        {
            DataTable[] data = new DataTable[tables.Count];
	        int iterator = 0;
	        foreach (var obj in tables)
	        {
	            data[iterator++] = SelectTable(obj.Key, obj.Value);
	        }
            return data;
        }

        public override DataTable SelectTable(string tableName, List<string> parameters)
        {
            NpgsqlDataReader reader;
            try
            {
                sqlConnection.OpenConnection();
                cmd.CommandText = PrepareSelectCommand(parameters, tableName);
                reader = cmd.ExecuteReader();
            }
            catch (NpgsqlException ex)
            {
                throw new SqlExceptions(ex.Message);
            }

            finally
            {
                sqlConnection.CloseConnection();
            }
            
            return reader.GetSchemaTable();
        }
        public override void Insert(Dictionary<string, string> record, string tableName)
        {
            try
            {
                sqlConnection.OpenConnection();

                cmd.CommandText = PrepareInsertCommand(record, tableName);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new SqlExceptions(ex.Message);
            }
            finally
            {
                sqlConnection.CloseConnection();
            }
        }
        
	    public override void CreateTable(Dictionary<string, string> dictionary, string tableName)
        {
            try
            {
                sqlConnection.OpenConnection();

                cmd.CommandText = PrepareCreateCommand(dictionary, tableName);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new SqlExceptions(ex.Message);
            }
            finally
            {
                sqlConnection.CloseConnection();
            }
        }

        public override DataTable ImportTable()
        {
            throw new System.NotImplementedException();
        }

	    public override void DropTable(string tableName)
	    {
	        try
	        {
                sqlConnection.OpenConnection();

	            cmd.CommandText = string.Format(DROPCOMMANDPATTERN, tableName);
	            cmd.ExecuteNonQuery();
	        }
	        catch (NpgsqlException ex)
	        {
                throw new SqlExceptions(ex.Message);
	        }
	        throw new NotImplementedException();
	    }

	    public override DataRowCollection GetRowsNames(string TableName)
        {

            NpgsqlDataReader npgsqlData = cmd.ExecuteReader();
            return npgsqlData.GetSchemaTable().Rows;
        }

	    public override bool Close()
	    {
            try
            {

                connection.Close();
                return true;

            }
            catch (SqlExceptions exception)
            {
                return false;
            }
	    }

        public string PrepareInsertCommand(Dictionary<string, string> record, string tableName)
        {
            string keys = string.Join(", ", record.Select(x => x.Key));
            string values = string.Join(", ", record.Select(x => x.Value));
            return string.Format(INSERTCOMMANDPATTERN, SchemaName, tableName, keys, values);
        }

        public string PrepareSelectCommand(List<string> parameters, string tableName)
        {
            string result = parameters.Aggregate("", (s, s1) => s + s1 + ", ");
            result = result.Substring(0, result.Length - 2);
            return string.Format(SELECTCOMMANDPATTERN, result, SchemaName, tableName);
        }

        public string PrepareCreateCommand(Dictionary<string, string> dictionary, string tableName)
        {
            string result = dictionary.Aggregate("", (temp, pair) => temp + pair.Value + " " + pair.Key + ", ");
            result = result.Substring(0, result.Length - 2);
            return string.Format(CREATECOMMANDPATTERN, SchemaName, tableName, result);
        }
	}
}