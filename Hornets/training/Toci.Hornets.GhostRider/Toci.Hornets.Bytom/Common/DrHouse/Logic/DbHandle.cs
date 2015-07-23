using System.Data.SqlClient;
using Toci.Hornets.Bytom.Common.DrHouse.Models;

namespace Toci.Hornets.Bytom.Common.DrHouse.Logic
{
    public abstract class DbHandle
    {
        public abstract SqlConnection ConnectToDb(ConnectionInfo dbInfo);

        public abstract void OpenConnection(SqlConnection connection);

        public abstract void CloseConnection(SqlConnection connnection);

        public abstract bool DbOperation(string command, SqlConnection connection);
    }
	
		//http://www.codeproject.com/Articles/4416/Beginners-guide-to-accessing-SQL-Server-through-C
}
