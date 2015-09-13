using System;
using System.Collections.Generic;
using System.Linq;

namespace Anathema.Patryk.TrainingTwo.Utils
{
    public class AbstractFactoryWithFuncAsKey<TKey,TValue>
    {
        protected Dictionary<Func<TKey,bool>, Func<TValue>> Dictonary;

        public TValue GetElement(TKey key)   
        {
            //text => text.EndsWith(".txt")
            //text => text.EndsWith(".xml")

            return Dictonary.Any(slownik => slownik.Key(key))
                ? Dictonary.First(item => item.Key(key)).Value()
                : default(TValue);

          
            //to samo, ale w foreachu
            /*  
             * foreach (var pair in Dictonary)
               {
                   if (pair.Key(key))
                       return pair.Value();
               }
               return default(TValue);
             * */
        } 
    }
}