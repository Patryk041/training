using Npgsql;
using Toci.Db.Interfaces;

namespace Toci.Db.Clients
{
    public class PostgreSqlClient : IDbClient
    {
        protected NpgsqlConnection Connection;
    }
}
