using System.Data;

namespace SQLlib
{
	public abstract class SqlBase
	{
		protected SqlBase()
		{

		}
		protected abstract void SqlConnection();
		protected abstract DataTable[] SelectAllTables();
		public abstract DataTable SelectTable(string tableName);
		public abstract void Insert(string[] record, string tableName);
		public abstract void CreateTable(string tableName);
		public abstract DataTable ImportTable();
	}
}