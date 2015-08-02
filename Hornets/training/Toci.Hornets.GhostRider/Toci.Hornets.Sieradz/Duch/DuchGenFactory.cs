using System.Collections.Generic;


namespace Toci.Hornets.Sieradz.Duch
{
    public abstract class DuchGenFactory<TKey, TValue> //where TValue : new()
    {
        protected Dictionary<TKey, TValue> FactoryDictionary ;

        public virtual TValue GetInstance(TKey key)
        {
           return FactoryDictionary[key];
        }
    }
}