using System.Linq;
using Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Model;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingSix
{
    public class CoffeeDataStorageUpdate : DataStorageQuery
    {
        private const string CommandName = "update";

        private const string CommandPatern = "{0} {1} set {2};";

        public override string GetSetDataCommand(StorageDataModel<object> model)  //update tabela set klucz = wartosc,klucz 
        {

            return string.Format(CommandPatern, CommandName, model.TableName,
                string.Join(", ", model.Data.Select(item => item.Key + " = " + FormatDatabaseValue(item.Value))));
        }

        public string GetSetDataCommand(StorageDataModel<object> model, string whereCondition)
        {
            return null;
        }
    }
}