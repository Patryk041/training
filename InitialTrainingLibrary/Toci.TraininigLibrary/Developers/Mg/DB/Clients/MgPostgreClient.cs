using System;
using System.Data;
using System.Data.Common;
using Npgsql;
using Toci.TraininigLibrary.Developers.Mg.DB.Base;

namespace Toci.TraininigLibrary.Developers.Mg.DB.Clients
{
    public class MgPostgreClient : MgClientsBase
    {
        private NpgsqlConnection postgreNpgsqlConnection;
        private const string postgreConnectionPattern = "Server={0};Port=5432;Database={1};User Id={2};Password={3};";
        private string connectionString;

        public MgPostgreClient(string userName, string password, string dbName, string dbAddress) : base(userName, password, dbName, dbAddress)
        {
            connectionString = String.Format(postgreConnectionPattern,DbAddress,DbName,UserName,Password);
        }

        public override DataSet GetData(string query)
        {
            using (postgreNpgsqlConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand NpgsqlSqlCommand = new NpgsqlCommand(query,postgreNpgsqlConnection);
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(NpgsqlSqlCommand);

                DataSet resultData = new DataSet();
                dataAdapter.Fill(resultData);
                return resultData;
            }
        }

        public override int SetData(string query)
        {
            using (postgreNpgsqlConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand NpqsqlSqlCommand = new NpgsqlCommand(query,postgreNpgsqlConnection);
                postgreNpgsqlConnection.Open();
                return NpqsqlSqlCommand.ExecuteNonQuery();
            }
        }
    }
}
