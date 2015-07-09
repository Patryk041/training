using System.Collections.Generic;
using System.Linq.Expressions;

namespace Toci.Hornets.Opole.S2yfr4nt
{
    public abstract class S2yfr4ntGenericFactory<TKey, TValue>
    {
        protected Dictionary<TKey, TValue> FactoryDictionary;

        public virtual TValue GetValue(TKey key)
        {
            return FactoryDictionary[key];
        }

        public TKey ReturnTKey()
        {
            return default(TKey);
        }
    }
}