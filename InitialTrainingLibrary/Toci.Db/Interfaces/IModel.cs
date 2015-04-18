using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Db.Interfaces
{
    public interface IModel
    {
        Dictionary<string, IDbField<object>> GetFields();
        IDbField<object> GetField(string columnName);
        string GetTableName();
        void SetWhere(string columnName);
        //IModel GetRow(DataRow row);
        List<IModel> GetDataRowsList(DataSet table);
    }
}
