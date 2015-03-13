using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.DbVirtualization
{
    public abstract class SqlQuery : IQuery
    {
        public abstract string GetQuery(IModel model);
    }
}
