using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingFour
{
    public class PatrykGenericList<T> : GhostRiderGenericList<T>
    {
        private int _top;
        private const int Capacity = 20;

        public PatrykGenericList()
        {
            _top = 0;
            items = new T[Capacity];
        }

        public override bool Add(T item)
        {
            if (_top == Capacity)
                return false;
           items[_top++] = item;
           return true;
        }

        public override bool Remove(T item)
        {
            int index = Array.IndexOf(items, item);
            if (index >= 0)
            {
                removeItem(item);
                return true;
            }
            return false;
        }

        private void removeItem(T item)
        {
            int index = Array.IndexOf(items, item);
            T[] tab = new T[items.Length-1];
            int count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if(i != index)
                    tab[count++] = items[i];
            }
            items = tab;
            _top--;
        }
    }
}