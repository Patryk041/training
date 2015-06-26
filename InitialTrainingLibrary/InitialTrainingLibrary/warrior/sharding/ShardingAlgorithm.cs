using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.warrior.sharding
{
    public class ShardingAlgorithm
    {
        public const int numberOfClusters = 128;

        public int GetShardNumber(int id) //4753243635753
        {
            return id % numberOfClusters;
        }

        public int GetShardNumber(string code) //warrior
        {
            return code.GetHashCode()%numberOfClusters;
        }
    }
}
