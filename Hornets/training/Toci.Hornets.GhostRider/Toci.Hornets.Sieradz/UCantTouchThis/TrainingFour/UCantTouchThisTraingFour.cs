using System;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Sieradz.UCantTouchThis.TrainingFour
{
    public class UCantTouchThisTraingFour<TItems> : GhostRiderGenericList<TItems>
    {
        private int _capacity;

        public UCantTouchThisTraingFour()
        {
            items = new TItems[0];
        }

        public int GetLength()
        {
            return _capacity;
        }

        public override bool Add(TItems item)
        {
            var oldItemsArray = items;
            items = new TItems[++_capacity];
            Array.Copy(oldItemsArray, items, oldItemsArray.Length);
            items[_capacity - 1] = item;
            return true;
        }

        public override bool Remove(TItems item)
        {
            if (!DoesArrayContainsElement(item)) return false;
            RemoveElement(item);
            return true;
        }

        private void RemoveElement(TItems item)
        {
            int newArrayCounter = 0;
            var oldItemsArray = items;

            items = new TItems[--_capacity];
            if(_capacity == 0) return;
            foreach (var oldItem in oldItemsArray)
                if (!oldItem.Equals(item)) items[newArrayCounter++] = oldItem;
        }

        private bool DoesArrayContainsElement(TItems item)
        {
            var flag = false;
            foreach (var it in items)
                flag |= it.Equals(item);
            return flag;
        }
    }
}