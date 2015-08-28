using System.Data;

namespace SQLlib.SqlInterfaces
{
    public interface ISqlDriver
    {
        DataTable[] SelectAllTables();
        DataTable SelectTable(string tableName);
        void Insert(string[] record, string tableName);
        void CreateTable(string tableName);
        DataTable ImportTable();

    }
}