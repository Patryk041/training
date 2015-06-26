using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.ClusterAccess
{
    public class DbCluster : IDbCluster
    {
        public IDbHandle GetClient(string id, IDbSharding sharding) // warrior
        {
            throw new NotImplementedException();
        }
    }
}
