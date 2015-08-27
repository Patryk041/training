using System.Collections.Generic;
using System.Data;

namespace SQLlib.SQL
{
    public interface ISqlDriver
    {
        DataTable[] SelectAllTables();
        DataTable SelectTable(string TableName);
        void Insert(string[] record);
        void CreateTable(string TableName);
        DataTable ImportTable();

    }
}