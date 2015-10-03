using System;
using System.Collections.Generic;
using System.Linq;
namespace Toci.Hornets.BankFactory

{
    public class AbstractFactoryWithFuncAsKey<TKey, TValue>
    {
        protected Dictionary<Func<TKey, bool>, Func<TValue>> Dictonary;

        public TValue GetElement(TKey key)
        {
            //text => text.EndsWith(".txt")
            //text => text.EndsWith(".xml")

            return Dictonary.Any(slownik => slownik.Key(key))
                ? Dictonary.First(item => item.Key(key)).Value()
                : default(TValue);
        }
    }
}