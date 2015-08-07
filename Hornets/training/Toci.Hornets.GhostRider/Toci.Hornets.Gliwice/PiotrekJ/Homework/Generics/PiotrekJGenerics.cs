using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Toci.Hornets.GhostRider.TrainingFour.Generics;
using Toci.Hornets.Gliwice.Dziara;

namespace Toci.Hornets.Gliwice.PiotrekJ.Homework.Generics
{
    public class PiotrekJGenerics<TPiotrekJitem> : GhostRiderGenericList<TPiotrekJitem>
    {
        private int _iterator;
        private int j;

        public PiotrekJGenerics(int _lenght)
        {
            items = new TPiotrekJitem[_lenght];
        }
        
        public override bool Add(TPiotrekJitem item)
        {
            items[_iterator] = item;
            if (items[_iterator].Equals(item))
            {
                ++_iterator;
                return true;
            }
            return false;
        }
        
        public override bool Remove(TPiotrekJitem item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null && items[i].Equals(item))
                {
                    items[i] = default(TPiotrekJitem);
                    j++;
                    _iterator--;
                }
                for (int k = 0; k < items.Length-1; k++)
                {
                    if (items[k] == null)
                    {
                        items[k] = items[k + 1];
                        items[k + 1] = default(TPiotrekJitem);
                    }
                }
            }
           if (j != 0) return true;
            return false;
        }

    }
}