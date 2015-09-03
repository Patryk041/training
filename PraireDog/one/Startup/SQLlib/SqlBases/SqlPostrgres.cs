using System.Data;
using Npgsql;
using SQLlib.SqlException;
using SQLlib.SqlInterfaces;

namespace SQLlib.SqlBases
{
	public class SqlPostrgres : SqlBase
	{
		private readonly NpgsqlCommand cmd = new NpgsqlCommand();
		private string CreateTableSchema { get; set; }
		private ISqlConnection sqlConnection;
		protected SqlPostrgres() : base()
		{ }

		protected override void SqlConnection()
		{
			throw new System.NotImplementedException();
		}

		protected override DataTable[] SelectAllTables()
		{
			throw new System.NotImplementedException();
		}

		public override DataTable SelectTable(string tableName)
		{
			NpgsqlDataReader reader;
			try
			{
				sqlConnection.OpenConnection();
				cmd.CommandText = "SELECT * FROM " + "\"" + CreateTableSchema + "\".\"" + tableName + "\"";
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

		public override void Insert(string[] record, string tableName)
		{
			try
			{
				sqlConnection.OpenConnection();
				cmd.CommandText = "INSERT INTO " + "\"" + CreateTableSchema + "\".\"" + tableName + "\"" +
								  "(ID, NumberOfAccount, NameOfBank, NumberOfBank) VALUES (1," + "'36249010440000420057684506', 'Alior',1111)";
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

		public override void CreateTable(string tableName)
		{
			try
			{
				sqlConnection.OpenConnection();

				cmd.CommandText = "CREATE TABLE " + "\"" + CreateTableSchema + "\".\"" + tableName + "\"" + " (" +
								  "ID int ," +
								  "NumberOfAccount text," +
								  "NameOfBank text," +
								  "NumberOfBank int)";
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
	}
}