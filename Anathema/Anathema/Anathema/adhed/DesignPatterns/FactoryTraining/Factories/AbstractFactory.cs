using System;
using System.Collections.Generic;

namespace Anathema.adhed.DesignPatterns.FactoryTraining.Factories
{
    public abstract class AbstractFactory<TKey, TValue>
    {
        protected Dictionary<TKey, Func<TValue>> Dictionary;

        public TValue GetElement(TKey key)
        {
            return Dictionary.ContainsKey(key) ? Dictionary[key]() : default(TValue);
        }

    }
}