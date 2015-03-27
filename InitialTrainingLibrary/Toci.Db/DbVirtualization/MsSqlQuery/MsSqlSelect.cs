using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.DbVirtualization.MsSqlQuery
{
    public class MsSqlSelect : SqlQuery
    {
        public override string GetQuery(IModel model)
        {
            throw new NotImplementedException();
        }
    }
}
