using System.Collections.Generic;
using System.Data;
using SQLlib.SqlInterfaces;

namespace SQLlib.SqlBases
{
	public abstract class SqlBase 
	{
		protected ISqlConnection<ISqlBase> sqlConnection;

		protected SqlBase() : base()
		{
		}

	    public abstract string SchemaName { get; set; }

	    public abstract void SqlConnection(IPropertiesConnection propertiesConnection,
            ISqlConnection<ISqlBase> sqlConnection);

	    public abstract DataTable[] SelectAllTables(Dictionary<string, List<string>> tables);
        public abstract DataTable SelectTable(string tableName, List<string> parametrs);
		public abstract void Insert(Dictionary<string,string> record, string tableName);
		public abstract void CreateTable(Dictionary<string, string> dictionary, string tableName);
		public abstract DataTable ImportTable();
		public abstract void DropTable(string tableName);
		public abstract DataRowCollection GetRowsNames(string TableName);
	    public abstract bool Close();
	}
}