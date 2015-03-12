using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Toci.TraininigLibrary.Developers.Dysq.Database
{
    public class PostgreSqlClientDysq : DysqSqlClientBase
    {
        protected NpgsqlConnection Connection;
        private const string _connectionPattern = "Server={0};Port=5432;Database={1};User Id={2};Password={3};";
        private string _connectionString;

        public PostgreSqlClientDysq(string name, string password, string dbAddress, string dbName) :
            base(name, password, dbAddress, dbName)
        {
            _connectionString= String.Format(_connectionPattern,DbAddress,DbName,UserName,Password);
        }

        public override DataSet GetData(string query)
        {
            using (Connection = new NpgsqlConnection(_connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, Connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

                var result = new DataSet();
                adapter.Fill(result);

                return result;
            }
        }

        public override int SetData(string query)
        {
            using (Connection = new NpgsqlConnection(_connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query,Connection);
                Connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}
