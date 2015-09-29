using System;
using System.Collections.Generic;
using System.Linq;

namespace Anathema.Patryk.TrainingTwo.Utils
{
    public class AbstractFactoryWithouFuncAsKey<TKey, TValue>
    {
        protected Dictionary<TKey, Func<TValue>> Dictionary;

        public TValue GetElement(TKey key)
        {
            return Dictionary.ContainsKey(key) ? Dictionary[key]() : default(TValue);
        }
    }
}