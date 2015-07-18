using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Gliwice.Didi.Genercis
{
    public class DidiGenercis<T> : GhostRiderGenericList<T>
    {
        private int _top;
        private const int Capacity = 20;

        public DidiGenercis()
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
            var tab = items.Where(val => !val.Equals(item)).ToArray();            
            if (tab.Length != items.Length)
            {
                _top -= items.Length - tab.Length;
                items = tab;
                return true;
            }
            return false;

        }
    }
}
