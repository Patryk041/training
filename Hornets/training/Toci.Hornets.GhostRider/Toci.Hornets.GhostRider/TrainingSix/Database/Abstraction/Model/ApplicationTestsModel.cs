using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Model
{
    public class ApplicationTestsModel : StorageDataModel<object>
    {
        public ApplicationTestsModel()
        {
            TableName = "ApplicationTests";

            Data = new Dictionary<string, object>
            {
                { "codesnipet", "haha"},
                { "rightanswers", "idento"},
                { "kolumnaliczbowa", 3},
            };
        }
    }
}