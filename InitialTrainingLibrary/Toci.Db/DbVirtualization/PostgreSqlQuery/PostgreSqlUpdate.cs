using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.DbVirtualization.PostgreSqlQuery
{
    public class PostgreSqlUpdate : SqlQuery
    {
        public override string GetQuery(IModel model)
        {
            throw new NotImplementedException();
        }
    }
}
