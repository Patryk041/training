using Toci.Db.Interfaces;

namespace Toci.Db.ClusterAccess
{
    public class ModularDbSharding : IDbSharding
    {
        public IDbHandle GetShard(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}