using System;
using System.Collections.Generic;
using System.Linq;
using Anathema.Generics;

namespace Anathema.Brzydal.Zad1GenerycznaLista
{
    public class BrzydkaGenerycznaLista<T> : GRList<T>
    {

        private T[] _items = new T[10];
        //
        private int _index = 0;


        public override bool AddElement(T item, bool unique = true)
        {
            if (!_items.Contains(item))
            {
                if (_items.Length >= _index + 1)
                {
                    _items[_index] = item;
                    _index++;
                }
                else
                {
                    Array.Resize(ref _items, _items.Length+10);
                    //Array.Copy(_items, _items, _items.Length + 10);
                    _items[_index] = item;
                    _index++;
                }
           

                return true;
            }
            return false;
        }

  
    }
}