using System.Data;
using Npgsql;


namespace Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Client
{
    public class PostgreSqlClient : DataStorageClient
    {
        private const string ConectionStringPattern = "User ID={0};Password=beatka;Host=localhost;Port=5432;Database={};";

        public PostgreSqlClient()
        {
            //formatujemy  ConectionStringPattern
        }

        public override DataSet GetData(string sql)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("User ID=postgres;Password=beatka;Host=localhost;Port=5432;Database=filadelfia;"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                //var datareader = command.ExecuteReader();

                DataSet result = new DataSet();

                adapter.Fill(result);

                return result;
            }
        }

        public override int ManipulateData(string command)
        {
           // SqlConnection
            //command.ExecuteNonQuery();
            throw new System.NotImplementedException();
        }



        //command.ExecuteNonQuery();

        // 1 polimorfizacja dostepu do bazy
        // 2 generycznosc przetwarzania / tworzenia zapytan
    }
}