using Toci.Hornets.GhostRider.TrainingTwo.ExtensionMethods;

namespace Toci.Hornets.GhostRider.TrainingTwo.Generics.Collections
{
    public class GenericCollection<T> where T : IFrogie, new()
    {
         T[] items = new T[10];

        public void AddItem(T item)
        {
            //logika dodania
        }
    }
}