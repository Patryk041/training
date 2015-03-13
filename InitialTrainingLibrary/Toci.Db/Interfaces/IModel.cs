using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Db.Interfaces
{
    public interface IModel
    {
        Dictionary<string, IDbField<object>> GetFields();
    }
}
