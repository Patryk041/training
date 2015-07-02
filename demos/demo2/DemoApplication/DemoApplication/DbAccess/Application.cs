namespace DemoApplication.DbAccess
{
    public class Application
    {
        public void DoAllThatAppDoes()
        {
            DbAccess acc = new DbAccess();

            acc.SaveData("dfsafgdsgsd", new MySqlDbClient());
        }
    }
}