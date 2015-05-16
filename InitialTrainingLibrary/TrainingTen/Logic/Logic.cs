using Toci.Db.Clients;
using Toci.Db.ClusterAccess;
using Toci.Db.DbVirtualization.PostgreSqlQuery;
using Toci.Db.Interfaces;

namespace TrainingTen.Logic
{
    public abstract class Logic
    {
        protected IDbHandle DbHandle;

        protected Logic()
        {
            DbHandle = new DbHandle(new PostgreSqlClient("postgres", "beatka", "localhost", "toci"), new PostgreSqlSelect(), new PostgreSqlInsert(), new PostgreSqlUpdate(), new PostgreSqlDelete());
        }
    }
}