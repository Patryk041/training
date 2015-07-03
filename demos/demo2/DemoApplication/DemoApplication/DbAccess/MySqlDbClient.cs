using DemoApplication.DbAccess.Interfaces;

namespace DemoApplication.DbAccess
{
    public class MySqlDbClient : IDbClient
    {
        public void Connect(string connectionString)
        {
            throw new System.NotImplementedException();
        }

        public int SaveData(string query)
        {
            throw new System.NotImplementedException();
        }
    }
}