using System.Collections.Generic;
using Anathema.Bolec;

namespace Anathema.adhed.Generics
{
    public abstract class GenericList<T>
    {
        protected List<T> _list;

        protected GenericList()
        {
            _list = new List<T>();
        } 

        public virtual void AddElement(T item)
        {
            _list.Add(item);    
        }

        public virtual List<T> GetList()
        {
            return _list;
        } 

    }
}