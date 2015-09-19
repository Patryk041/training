using System;
using System.Collections.Generic;
using Anathema.Generics;

namespace Anathema.Patryk.TrainingOne.Factories
{
    public abstract class AbstractFactory<TKey, TValue>
    {
        protected Dictionary<TKey, Func<TValue>> Dictonary;

        public TValue GetElement(TKey key)
        {
           return Dictonary.ContainsKey(key) ? Dictonary[key]() : default(TValue);
        }
    }
}