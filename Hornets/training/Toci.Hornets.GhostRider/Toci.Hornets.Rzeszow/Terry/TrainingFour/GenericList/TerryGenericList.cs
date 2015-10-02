using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Rzeszow.Terry.TrainingFour.GenericList
{
    public class TerryGenericList<T> : GhostRiderGenericList<T>
    {
        public TerryGenericList(int arrSize)
        {
            items = new T[arrSize];
        }

        public override bool Add(T item)
        {
            for (var i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    return true;
                } 

                if (!items[i].Equals(default(T))) continue;
                items[i] = item;
                return true;
            }
            return false;
        }

        public override bool Remove(T item)
        {
            var index = Array.IndexOf(items, item);

            if (index == -1) return false;
            items[index] = default(T);
            return true;
        }
    }
}  