using Npgsql;

namespace SQLlib.SqlInterfaces
{
    public interface ISqlConnection
    {
        void SetConnection(string host,string user,string password,string dBname);

        NpgsqlConnection GetConnection();

        bool CheckConnection();
        void CloseConnection();
        void OpenConnection();
    }
}