using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization.Clients
{
    public class MssqlClient : IClient
    {
        protected SqlConnection Connection;
        private const string connectionPattern = "user id={0};password={1};server={2};Trusted_Connection=yes;database={3};connection timeout=30";

        private string connectionString;
        public MssqlClient(string name, string password, string dbAddress, string dbName) //: base(name, password, dbAddress, dbName)
        {
            this.connectionString = string.Format(connectionPattern, name, password, dbAddress, dbName);
        }

        public DataSet GetData(string query)
        {
            using (this.Connection = new SqlConnection(this.connectionString))
            {
                var adapter = new SqlDataAdapter(new SqlCommand(query, this.Connection));
                var result = new DataSet();

                adapter.Fill(result);

                return result;
            }
        }

        public int Save(string query)
        {
            using (this.Connection = new SqlConnection(this.connectionString))
            {
                var sqlCommand = new SqlCommand(query, this.Connection);
                this.Connection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
