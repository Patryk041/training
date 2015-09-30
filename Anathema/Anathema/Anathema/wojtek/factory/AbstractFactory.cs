using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.wojtek.factory
{
    public abstract class AbstractFactory<Tkey,Titem>
    {
        Dictionary<Tkey,Titem> dictionary = new Dictionary<Tkey,Titem>();

        public Titem Create(Tkey key)
        {
           return  dictionary.ContainsKey(key) ? dictionary[key] : default(Titem);
        }



        
    }
}
