using System.Collections.Generic;
using System.Linq;
using Anathema.Bolec;

namespace Anathema.adhed.CityTrainingTwo.Generics
{
    public abstract class GenericListManager<T>
    {
        protected List<T> GList;

        protected GenericListManager()
        {
            GList = new List<T>();
        } 

        public void AddElement(T item)
        {
            GList.Add(item);
        }

        public List<T> GetList()
        {
            return GList;
        }

        public void JoinList(List<T> listToJoin)
        {
            foreach (var item in listToJoin)
            {
               GList.Add(item);
            }
        }

        public int CountElements()
        {
            return GList.Count();
        }

        public virtual void RemoveDuplicates(IEqualityComparer<T> comparer)
        {
            GList = GList.Distinct(comparer).ToList();
        }

        public abstract void LoadElements(string path);
        public abstract bool CheckElementExists(string value);
        public abstract void RemoveElement(string value);

        public abstract int CountElementsStartWithLetter(string letter);

    }
}