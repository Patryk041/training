using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using Npgsql;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto.Agreement;
using SQLlib.SqlException;
using SQLlib.SqlInterfaces;

namespace SQLlib.SqlBases
{
	public class SqlPostgres : SqlBase 

	{
		private NpgsqlConnection connection;
		private readonly NpgsqlCommand cmd = new NpgsqlCommand();
		protected override string SchemaName { get; set; }


		protected SqlPostgres() : base()
		{
		}

		protected override void SqlConnection(IPropertiesConnection propertiesConnection,
			ISqlConnection<SqlPostgres> sqlConnection)
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

		protected override DataTable[] SelectAllTables(List<string> tables)
		{
			DataTable[] data = new DataTable[tables.Count];
			for (int i = 0; i < tables.Count; i++)
			{
				data[i] = SelectTable(tables[i]);
			}
			return data;
		}

		public override DataTable SelectTable(string tableName)
		{
			NpgsqlDataReader reader;
			try
			{
				sqlConnection.OpenConnection();
				cmd.CommandText = "SELECT * FROM " + "\"" + SchemaName + "\".\"" + tableName + "\"";
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
				/// 
				/// Dodaj do tabeli : id 1, nazwaBanku Alio.
				/// string[] recor = string[0] id 1
				///					 string[1] nazwa Alio
				///					dicrionary[0] id 1
				///					dictionary[1] nazwa Alio
				/// dictionary[0].key
				sqlConnection.OpenConnection();

				cmd.CommandText = "INSERT INTO " + "\"" + SchemaName + "\".\"" + tableName + "\"" +
								  "("+record.Keys+") VALUES ("+""+")";

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

		public override void CreateTable(string tableName, Dictionary<string,string> dictionary)
		{
			try
			{

				sqlConnection.OpenConnection();

				string result = dictionary.Aggregate("",(temp,pair)=> temp + pair.Value + " " + pair.Key + ", ");

				cmd.CommandText = "CREATE TABLE " + "\"" + SchemaName + "\".\"" + tableName + "\"" + " (" +
					result.Substring(0,result.Length-2)
					+")";
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

		public override DataRowCollection GetRowsNames(string TableName)
		{

			NpgsqlDataReader npgsqlData = cmd.ExecuteReader();
			return npgsqlData.GetSchemaTable().Rows;
		}
	}
}