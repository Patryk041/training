using System.Collections.Generic;
using Anathema.Lurppis;

namespace Anathema.Generics
{
    public abstract class AbstractFactory<T> //where T : MyClass // where T :  GRList<T>, IEnumerable<T>, new()
        //: IAbstractFactory<T>
    {
        protected Dictionary<string, T> factoryDictonary = new Dictionary<string, T>(); //Func<T> Lazy<T>  .Value

        protected AbstractFactory() 
        {
            factoryDictonary.Add("test", (T)(object)(new MyClass()));
        }

        public T Create(string index)
        {
            return factoryDictonary.ContainsKey(index) ? factoryDictonary[index] : default(T);
        }
    }
}