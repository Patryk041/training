using System;
using System.Collections.Generic;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.Utils
{
    public abstract class GenericFactory<TKey, TValue>
    {
        protected Dictionary<TKey, TValue> GenericDictionary;

        public TValue GetValue(TKey key)
        {
            return GenericDictionary.ContainsKey(key) ? GenericDictionary[key] : default(TValue);
        }
    }
}