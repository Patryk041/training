using System.Data;
using Cassandra;

namespace SQLlib.SqlBases
{
	public class SqlCassandra : SqlBase
	{

		protected SqlCassandra() : base()
		{
			
		}

		public string Host { get; set; }
		public string NameDataBase { get; set; }
		protected override void SqlConnection()
		{
			Cluster cluster = Cluster.Builder().AddContactPoint(Host).Build();
			ISession session = cluster.Connect(NameDataBase);
		}

	    protected override DataTable[] SelectAllTables()
	    {
	        throw new System.NotImplementedException();
	    }

	    public override DataTable SelectTable(string tableName)
	    {
	        throw new System.NotImplementedException();
	    }

	    public override void Insert(string[] record, string tableName)
	    {
	        throw new System.NotImplementedException();
	    }

	    public override void CreateTable(string tableName)
	    {
	        throw new System.NotImplementedException();
	    }

	    public override DataTable ImportTable()
	    {
	        throw new System.NotImplementedException();
	    }
	}
}