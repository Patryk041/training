using DemoApplication.Interfaces;

namespace DemoApplication
{
    public class MysqlCommunication : ICommunication
    {
        public string username { get; set; }

        public bool Connect(string connectionString)
        {

            throw new System.NotImplementedException();
        }
    }
}