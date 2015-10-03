using System;
using System.Security.Cryptography.X509Certificates;

namespace Anathema.marcin022
 
{
    public class ListGeneric<T>
    {
        protected int initialSize = 10;
         public  T[] items = new T[10];
        public int index = 0;
        public T[] temp;

        public void Add(T item)
        {
            if (index < items.Length)
            {
                items[index] = item;
                index++;
            }
            else
            {
               temp = new T[items.Length];
                Array.Copy(items, temp, items.Length );
                items = new T[temp.Length+10];
                Array.Copy(temp,items,temp.Length);
                items[index] = item;
                index++;
            }
        }
    }
}