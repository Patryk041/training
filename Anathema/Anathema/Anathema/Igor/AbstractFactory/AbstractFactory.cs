using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Igor.AbstractFactory
{
    public abstract class AbstractFactory<TKey, T>
    {
        protected Dictionary<TKey, Func<T>> dictionary;
        
        public T getElement(TKey key)
        {
            return (dictionary.ContainsKey(key) ? dictionary[key]() : default(T));
        }
    }
}
