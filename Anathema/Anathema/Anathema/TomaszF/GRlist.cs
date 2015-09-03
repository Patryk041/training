using System;
using System.Linq;

namespace Anathema.TomaszF
{
    public class GRListEx<T>
    {
        protected T[] items = new T[10];
        protected int iterator = 0;

        public virtual bool AddElement(T item, bool unique = true)
        {
            if (items.Contains(item))
            {
                return false;
            }

            if (iterator >= items.Length)
            {
                Array.Resize<T>(ref items, items.Length*2);
            }
            items[iterator++] = item;


            return true;
        }

   
    }
}
