using System.Collections.Generic;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization.Queries
{
    public class PostgreSqlDelete : SqlQuery, IDelete
    {
        private const string PATTERN = "delete from {0} where {1};";
        private const string equalSign = "=";
        private const string andSign = " and ";

        public override string GetQuery(IModel model)
        {

            var whereDelete = new List<string>();

            foreach (var item in model.GetDbTableRow())
            {
                if (item.Value.IsWhere())
                {
                    whereDelete.Add(item.Value.GetColumnName() + equalSign + GetSurroundedValue(item.Value.GetValue()));
                }
            }

            var where = string.Join(andSign, whereDelete);

            return string.Format(PATTERN, model.TableName, where);
        }
    }
}