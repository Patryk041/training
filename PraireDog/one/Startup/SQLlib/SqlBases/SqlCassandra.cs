using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Cassandra;
using SQLlib.SqlException;
using SQLlib.SqlInterfaces;

namespace SQLlib.SqlBases
{
	public class SqlCassandra : SqlBase
	{


		protected SqlCassandra() : base()
		{
			
		}

		public string Host { get; set; }
		public string NameDataBase { get; set; }
        public Cluster Cluster { get; set; }
	    public override string SchemaName { get; set; }
	    public ISession Session { get; set; }

	    public override void SqlConnection(IPropertiesConnection propertiesConnection, ISqlConnection<ISqlBase> sqlConnection)
	    {
	        
           Cluster = Cluster.Builder().AddContactPoint(Host).Build();
                    
                       	    }

	    public override DataTable[] SelectAllTables(Dictionary<string, List<string>> tables)
	    {
	        throw new System.NotImplementedException();
	    }

	    public override DataTable SelectTable(string tableName, List<string> parametrs)
	    {
	        Session = Cluster.Connect();
	        string select = parametrs.Aggregate("", (key, value) => key + value + ", ");
	        var selectTable = Session.Execute("SELECT " + select.Substring(0, select.Length-2) + " FROM " + tableName);
	        return ConvertRowSetToDataTable(selectTable,tableName, parametrs);
             
	    }

	    public DataTable ConvertRowSetToDataTable(RowSet rowset, string TableName,List<string> parametrs)
	    {
            DataTable dataTable = new DataTable();
	        DataColumn dataColumn = new DataColumn();
	        int i = 0;
	        foreach (var row in rowset)
	        {
	            
                dataColumn = dataTable.Columns.Add(row.GetColumn(parametrs[i]).ToString());
	            i++;

	        }
	        dataTable = dataColumn.Table;
	        return dataTable ;
	    }


	    public override void Insert(Dictionary<string, string> record, string tableName)
	    {
	        try
	        {

	        }
	        catch (SqlExceptions exceptions)
	        {
	            Cluster.Shutdown();
	        }
	    }

	    public override void CreateTable(string tableName, Dictionary<string, string> dictionary)
	    {
	        throw new System.NotImplementedException();
	    }

	    public override DataTable ImportTable()
	    {
	        throw new System.NotImplementedException();
	    }

	    public override void DropTable()
	    {
	        throw new System.NotImplementedException();
	    }

	    public override DataRowCollection GetRowsNames(string TableName)
	    {
	        throw new System.NotImplementedException();
	    }

	    public override bool Close()
	    {
	        try
	        {

	            Cluster.Shutdown();
                return true;
	           
	        }
	        catch(SqlExceptions exception)
	        {
	            return false;
	        }
	    }
	}
}