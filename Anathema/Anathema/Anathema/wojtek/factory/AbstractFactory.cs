using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.wojtek.factory
{
    public abstract class AbstractFactory<Tkey,Titem>
    {
        protected Dictionary<Tkey, Func<Titem>> AbstFactDict;

        public Titem Create(Tkey key)
        {
           return  AbstFactDict.ContainsKey(key) ? AbstFactDict[key]() : default(Titem);
        }



        
    }
}
