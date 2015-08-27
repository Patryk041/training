namespace SQLlib
{
    public interface ISqlConnection
    {
        void SetConnection(string host);
        void SetConnection(string host,string port);
        bool CheckConnection();
        void CloseConnection();
        



    }
}