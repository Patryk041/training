using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Model
{
    public abstract class StorageDataModel<T>
    {
        public string TableName { get; set; }

        public Dictionary<string, T> Data { get; set; }

    }
}