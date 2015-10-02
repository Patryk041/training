using System.Linq;

namespace Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Model
{
    public class DataStorageInsert : DataStorageQuery
    {
        private const string CommandName = "insert";

        private const string CommandPattern = "{0} into {1} ({2}) values ({3});";

        public override string GetSetDataCommand(StorageDataModel<object> model)
        {
            return string.Format(CommandPattern, CommandName, model.TableName, GetColumnsDelimitedList(model), string.Join(", ", model.Data.Select(item => FormatDatabaseValue(item.Value))));
        }


    }
}