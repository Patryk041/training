using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.DbVirtualization.MsSqlQuery
{
    public class MsSqlDelete : SqlQuery
    {
        private const string PATTERN = "delete from {0} where {1};";
        public override string GetQuery(IModel model)
        {
            //string where = 
            return string.Format(PATTERN, model.GetTableName(), string.Empty);
        }
    }
}
