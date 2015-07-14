using System.Data;

namespace DemoApplication.DbAccess.Interfaces
{
    public interface IDbClient
    {
        void Connect(string connectionString);


        int SaveData(string query);

        DataSet GetPatientInformation(string pesel);
    }
}