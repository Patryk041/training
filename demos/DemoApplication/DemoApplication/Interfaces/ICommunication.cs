namespace DemoApplication.Interfaces
{
    public interface ICommunication
    {
        string username { get; set; }
        bool Connect(string connectionString);
    }
}