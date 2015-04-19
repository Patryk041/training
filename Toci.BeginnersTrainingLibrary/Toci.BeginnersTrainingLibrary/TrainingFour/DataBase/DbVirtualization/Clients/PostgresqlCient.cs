using Npgsql;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization.Clients
{
    public class PostgresqlCient : IClient
    {
        private string connectionString;
        private const string connectionPattern = "Server={0};Port=5432;Database={1};User Id={2};Password={3};";

        public PostgresqlCient(string userName, string password, string dbAddres, string dbName)
        {
            connectionString = string.Format(connectionPattern, dbAddres, dbName, userName, password);
        }
        public int Save(string query)
        {
            using (var Connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, Connection);
                Connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}