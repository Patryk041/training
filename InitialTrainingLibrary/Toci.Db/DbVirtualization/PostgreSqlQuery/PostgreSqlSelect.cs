using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.DbVirtualization.PostgreSqlQuery
{
    public class PostgreSqlSelect : SqlQuery
    {
        private const int minimumLENGHT = 1;
        private const string PATTERN = "select {0} from {1} ";
        private const string whereConst = " where ";
        private const string wherePATTERN = "{0} {1} {2}";//pole1 = "dupa" and pole2 = "jwdupa"

        public override string GetQuery(IModel model)
        {
            string result = string.Empty;

            var fields = model.GetFields();

            var columns = String.Join(", ",fields.Select(x=>x.Value.GetColumnName()).ToArray());
            var tableName = model.GetTableName();
            var where = string.Join(" and ", fields.Where(x => x.Value.IsWhere()).Select(x=>String.Format(wherePATTERN,x.Value.GetColumnName(),x.Value.GetSelectClause(),GetSurroundedValue(x.Value.GetValue()))).ToArray());


            return where.Length > minimumLENGHT ? string.Format(PATTERN, columns, tableName) + whereConst + where 
                : string.Format(PATTERN, columns, tableName);




        }
    }
}
