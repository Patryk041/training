using System.Collections.Generic;
using System.Data;
using SQLlib.SqlInterfaces;

namespace SQLlib.SqlBases
{
    public interface ISqlBase
    {
        string SchemaName { get; set; }

        void SqlConnection(IPropertiesConnection propertiesConnection,
            ISqlConnection<SqlPostgres> sqlConnection);

        DataTable[] SelectAllTables(List<string> tables);
        DataTable SelectTable(string tableName);
        void Insert(Dictionary<string,string> record, string tableName);
        void CreateTable(string tableName, Dictionary<string, string> dictionary);
        DataTable ImportTable();
        void DropTable();
        DataRowCollection GetRowsNames(string TableName);
        bool Close();
    }
}