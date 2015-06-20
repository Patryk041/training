using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.TrainingTwo.Generics.Factory.ChessFigures
{
    public class GenericFactory<TIndex, TInstance>
    {
         protected Dictionary<TIndex, TInstance> items = new Dictionary<TIndex, TInstance>();

         public TInstance GetInstance(TIndex type)
         {
             return items.ContainsKey(type) ? items[type] : default(TInstance);
         }
    }
}