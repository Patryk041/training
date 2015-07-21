using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingFour
{
    public class GenericListPr0Fes0R<TItems> : GhostRiderGenericList<TItems>
    {
        protected int start = 0;
        protected int ilosc = 20;
        public override bool Add(TItems item)
        {
            var value = items.Length;
            if (value >= ilosc) return false;
            items[value++] = item;
            return true;
        }

        public override bool Remove(TItems item)
        {
           // for (start; start < ilosc; start++)
           // {
           //     if (item == items[start])
           //     {
            //        items[start] = null;
            //    }
            //}   
	        return false;
        }
    }
}