using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.wojtek.factory
{
    public abstract class AbstractFactory<TKey,TItem>
    {
        protected Dictionary<TKey, Func<TItem>> AbstFactDict;

        public TItem Create(TKey key)
        {
           return  AbstFactDict.ContainsKey(key) ? AbstFactDict[key]() : default(TItem);
        }



        
    }
}
