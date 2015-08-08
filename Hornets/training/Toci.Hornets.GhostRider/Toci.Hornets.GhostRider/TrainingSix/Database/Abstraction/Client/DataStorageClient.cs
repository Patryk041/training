using System.Data;

namespace Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Client
{
    public abstract class DataStorageClient
    {
        protected string DatabaseAddress { get; set; }


        public abstract DataSet GetData(string command);

        public abstract int ManipulateData(string command);
    }
}