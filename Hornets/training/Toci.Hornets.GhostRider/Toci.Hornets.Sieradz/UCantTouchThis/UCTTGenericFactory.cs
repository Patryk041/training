using System.Collections.Generic;

namespace Toci.Hornets.Sieradz.UCantTouchThis
{
    public abstract class UCTTGenericFactory<TKey, TValue>
    {
        protected Dictionary<TKey, TValue> Factory;

        public virtual TValue GetInstance(TKey key)
        {
            return (Factory.ContainsKey(key)) ? Factory[key] : default(TValue);
        }
    }
}