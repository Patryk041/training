using System.Collections.Generic;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.Utils
{
    public class GenericFactory<TKey, TValue>
    {
        protected Dictionary<TKey, TValue> GenericDictionary = new Dictionary<TKey, TValue>();

        public TValue GetValue(TKey key)
        {
            return GenericDictionary.ContainsKey(key) ? GenericDictionary[key] : default(TValue);
        }
    }
}