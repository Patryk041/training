using System;
using System.Collections.Generic;

namespace Anathema.Lurppis.FactoryMethos.Abstract.AbstractFactory
{
    public abstract class AbstractAnimkalFactory<TKey, TValue>
    {
        protected Dictionary<TKey, Func<TValue>> Dictionary;

        public TValue GetElemenValue(TKey key)
        {
            return Dictionary.ContainsKey(key) ? Dictionary[key]() : default(TValue);
        }
    }
}