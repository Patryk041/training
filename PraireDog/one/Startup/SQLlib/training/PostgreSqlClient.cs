using System.Data;
using Npgsql;

namespace SQLlib.training
{
    public class PostgreSqlClient
    {
        public DataSet GetData(string sql)
        {
            NpgsqlConnection connection = new NpgsqlConnection();
        }
    }
}