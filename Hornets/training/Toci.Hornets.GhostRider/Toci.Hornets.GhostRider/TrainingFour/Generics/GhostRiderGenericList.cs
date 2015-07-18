namespace Toci.Hornets.GhostRider.TrainingFour.Generics
{
    public abstract class GhostRiderGenericList<TItems>
    {
        protected TItems[] items;

        public abstract bool Add(TItems item);

        public abstract bool Remove(TItems item);

        public virtual TItems[] GetAllItems()
        {
            return items;
        }
    }
}