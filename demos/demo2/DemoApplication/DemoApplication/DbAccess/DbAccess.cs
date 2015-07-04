using DemoApplication.DbAccess.Interfaces;

namespace DemoApplication.DbAccess
{
    public class DbAccess
    {


        //query = 'insert into tabelka () values (fdsg);'
        public void SaveData(string query, IDbClient dbClient)
        {
            dbClient.Connect("dfsafgsdg");

            dbClient.SaveData(query);
        }
    }
}