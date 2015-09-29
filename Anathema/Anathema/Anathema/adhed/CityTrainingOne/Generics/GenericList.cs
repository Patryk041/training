using System.Collections.Generic;
using System.Linq;
using Anathema.Bolec;

namespace Anathema.adhed.Generics
{
    public abstract class GenericList<T>
    {
        protected List<T> List;

        protected GenericList()
        {
            List = new List<T>();
        } 

        public virtual void AddElement(T item)
        {
            List.Add(item);    
        }

        public virtual List<T> GetList()
        {
            return List;
        }

        public virtual void joinList(List<T> listToJoin)
        {
        }

    }
}