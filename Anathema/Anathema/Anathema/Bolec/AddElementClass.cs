using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Anathema.Bolec
{
    public class AddElementClass<T> : MyGRList<T>
    {
        public override bool AddElement(T item, bool unique = true)
        {
            if (unique && _items.Contains(item))
            {
                Console.WriteLine("item exist in this array already");
                return false;
            }

            {
                int newsize = Enumerable.Count(_items) + 1;
                Array.Copy(
                    _items,
                    newitems,
                    newsize);
                int _index = newsize - 1;
                newitems[_index] = item;
                _index++;
                return true;
            }
        }
    }   
}