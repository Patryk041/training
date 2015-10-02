using System.Collections.Generic;

namespace Anathema.Patryk.TrainingTwo.Utils
{
    public abstract class AbstractFactory<TKey,TValue>
    {
        protected Dictionary<TKey, TValue> Dictionary;

        public TValue GetElement(TKey key)
        {
            return CanCreateElement(key) ? CreateElement(key) : default(TValue);
        }

        protected abstract bool CanCreateElement(TKey key);

        protected abstract TValue CreateElement(TKey key);
    }
}