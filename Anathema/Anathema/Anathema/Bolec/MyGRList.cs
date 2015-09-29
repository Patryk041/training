using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Anathema.Bolec
{
    public class MyGRList<T> //: ICollection<T>
    {
        protected T[] _items = new T[10];

        protected T[] newitems = new T[10];

        protected int _index = 0;

        public virtual bool AddElement(T item, bool unique = true)
        {
            return true;
        }

//        public void Resizer(Array array)
//        {
//            int newsize = Enumerable.Count(Array) + 1;
//            Array.Resize<T>(ref newitems, 11);
//            Array.Copy(
//                _items,
//                newitems,
//                _items.Length);
//        }

    }
}
         
