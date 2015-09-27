using System;
using System.Collections.Generic;

namespace Anathema.Igor.ExceptionTranslator
{
    public abstract class AbstractFactory<T, T1>
    {
        protected Dictionary<T, Func<T1>> Elements = new Dictionary<T, Func<T1>>();

        public T1 GetElement(T key)
        {
            return (Elements.ContainsKey(key) ? Elements[key]() : default(T1));
        }
    }
}