using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization.Queries
{
    public class MsSqlInsert : SqlQuery, IInsert// IUpdate
    {
        private const string PATTERN = "insert into {0} ({1}) values ({2});";

        public override string GetQuery(IModel model)
        {
            string columnNames = string.Join(COLUMNS_DELIMITER, model.GetDbTableRow().Select(item => item.Key));
            string columnValues = string.Join(COLUMNS_DELIMITER, model.GetDbTableRow().Select(item => GetSurroundedValue(item.Value.GetValue())));
            // 'beatka',5

            return string.Format(PATTERN, model.TableName, columnNames, columnValues);
        }
    }
}
