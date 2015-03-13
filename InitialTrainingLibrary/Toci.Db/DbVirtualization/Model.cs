using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.DbVirtualization
{
    public abstract class Model : IModel
    {
        protected Dictionary<string, IDbField<object>> Fields; 
        public Dictionary<string, IDbField<object>> GetFields()
        {
            return Fields;
        }
    }
}
