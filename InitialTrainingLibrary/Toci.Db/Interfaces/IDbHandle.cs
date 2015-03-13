using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Db.Interfaces
{
    public interface IDbHandle
    {
        DataSet GetData();

        int InsertData();
        int UpdateData();
        int DeleteData();

    }
}
