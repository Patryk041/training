using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Mg.DB.Interface
{
    interface IMgDbClient
    {
        DataSet GetData(string query);
        int SetData(string query);
    }
}
