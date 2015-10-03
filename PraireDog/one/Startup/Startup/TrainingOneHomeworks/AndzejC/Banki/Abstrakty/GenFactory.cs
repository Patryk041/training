using System.Collections.Generic;
namespace Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty
{
    public abstract class GenFactory<TKey,TValue>
    {
        protected Dictionary<TKey, TValue> ItemList;

        public TValue GetElement(TKey key)
        {
            return ItemList[key];
        }
    }
}