using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// robiliśmy w trójkę. :)

namespace Anathema.Igor
{
    public class GRListEx<T>
    {
        protected T[] items = new T[0];
        protected int iterator = 0;

        public virtual bool AddElement(T item, bool unique = true)
        {
            foreach(var i in items)
            {
                if (i.Equals(item)) return false;
            }

            if(iterator>items.Length-1)
            {
                Array.Resize<T>(ref items, items.Length + 10);
            }
            items[iterator++] = item;


            return true;
        }

        public virtual T getItem(int i)
        {
            if (i <= iterator) return items[i];
            else return default(T);
        }

        public virtual int getSize()
        {
            return iterator + 1;
        }

        public virtual T[] getArray()
        {
            return items;
        }
    }
}
