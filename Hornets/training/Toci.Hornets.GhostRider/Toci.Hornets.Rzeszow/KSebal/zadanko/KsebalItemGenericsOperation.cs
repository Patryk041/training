using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Rzeszow.KSebal.zadanko
{
   public class KsebalItemGenericsOperation<TItem>:GhostRiderGenericList<TItem> where TItem:IEnumerable<TItem>,ICollection<TItem>
   {
       public override bool Add(TItem item)
       {
           items=new TItem[items.Length+1];
           items.SetValue(item,items.Length);
           return true;
       }

       public override bool Remove(TItem item)
       {
           return true;

       }
    }

   
}
