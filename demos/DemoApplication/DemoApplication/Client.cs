using DemoApplication.Interfaces;

namespace DemoApplication
{
    public class Client
    {
        private ICommunication communication;

        public void SaveClient()
        {
            //communication.username
            communication = new MysqlCommunication();
            communication.Connect("dsafdsa");
        }
    }
}