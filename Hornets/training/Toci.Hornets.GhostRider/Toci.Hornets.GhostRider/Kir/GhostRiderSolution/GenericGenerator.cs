using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.Kir.GhostRiderSolution
{
    public abstract class GenericGenerator<T>
    {
        protected Dictionary<string, List<T>> GenericElementsDictionary; // = new Dictionary<string, List<T>>();

        public List<T> GetList(string key)
        {
            return GenericElementsDictionary[key];
        }

        protected virtual void GenerateGenericList(string key)
        {
            // generate for T
            // add to GenericElementsDictionary for key
        }
    }
}