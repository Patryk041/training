using System.Linq;
using Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Model;

namespace Toci.Hornets.Rzeszow.KSebal.Db
{
    public class KsebalUpdateDb:DataStorageQuery
    {
        private const string ComandName = "update";
        private const string pattern = "{0} set {1} = {2}";

        public override string GetSetDataCommand(StorageDataModel<object> model)
        {
            return string.Format(pattern, ComandName, model.TableName, string.Join(",",
                model.Data.Select(item => item.Key + "=" + item.Value).ToArray()));
        }
    }
}