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
    public class DidiGenercis<Titem> : GhostRiderGenericList<Titem>
    {
        private int _top;
        private const int Capacity = 20;

        public DidiGenercis()
        {
            _top = 0;
            items = new Titem[Capacity];
        }

        public override bool Add(Titem item)
        {
            if (_top == Capacity)
                return false;
           items[_top++] = item;
           return true;
        }

        public override bool Remove(Titem item)
        {
            var itemTab = items.Where(x => !x.Equals(item)).ToArray();            
            if (itemTab.Length != items.Length)
            {
                _top -= items.Length - itemTab.Length;
                items = itemTab;
                return true;
            }
            return false;

        }
    }
}
