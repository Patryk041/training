using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Bytom.InkNinja.TrainingFour
{
    class InkGenericTask <TItems>: GhostRiderGenericList<TItems>
    {

        public override bool Add(TItems item)
        {
            TItems[] temp = new TItems[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
            }
            temp[items.Length] = item;
            items = temp;
            return true;
        }

        public override bool Remove(TItems item)
        {
            bool f = false;
            TItems[] temp = new TItems[items.Length-1];
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item) && !f)
                {
                    f = true;
                }
                else
                {
                    if (f)
                        temp[i - 1] = items[i];
                    else
                        temp[i] = items[i];
                }

            }
            if (f)
                items = temp;
            return f;

        }

        public override TItems[] GetAllItems()
        {
            return items;
        }
    }
}
