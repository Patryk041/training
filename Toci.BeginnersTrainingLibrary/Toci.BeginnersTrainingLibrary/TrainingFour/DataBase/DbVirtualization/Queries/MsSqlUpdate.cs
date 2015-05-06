using System.Linq;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization.Queries
{
    public class MsSqlUpdate : SqlQuery, IUpdate
    {
        private const string Pattern = "UPDATE {0} SET {1} WHERE {2};";
        private const string AssignmentPattern = "{0} = {1}";
        private const string AndOperator = " AND ";
        private const string Comma = ", ";
        private const int MinStatementLength = 2;

        public override string GetQuery(IModel model)
        {
            var where = GetWhereStatement(model);
            if (where.Length < MinStatementLength)
                return "";

            return string.Format(Pattern, model.TableName, GetSetStatement(model), where);
        }

        private string GetSetStatement(IModel model)
        {
            var list = model.GetDbTableRow().Select(item => string.Format(AssignmentPattern, item.Key, GetSurroundedValue(item.Value.GetValue()))).Cast<object>().ToList();
            return string.Join(Comma, list);
        }

        private string GetWhereStatement(IModel model)
        {
            var list = (from item in model.GetDbTableRow() where item.Value.IsWhere() select string.Format(AssignmentPattern, item.Key, GetSurroundedValue(item.Value.GetValue()))).Cast<object>().ToList();
            return string.Join(AndOperator, list);
        }
    }
}