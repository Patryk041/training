using System.Data.SqlClient;
using System.Net.NetworkInformation;
using Toci.Hornets.Bytom.Common.DrHouse.Types;

namespace Toci.Hornets.Bytom.Common.DrHouse.Logic
{
    public abstract class DbHandle
    {
        public abstract SqlConnection ConnectToDb(ConnectionInfo dbInfo);

        public abstract void OpenConnection(SqlConnection connection);

        public abstract void CloseConnection(SqlConnection connnection);

        public abstract bool DbOperation(string command, SqlConnection connection);
    }
}