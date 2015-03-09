using System.Collections;
using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution.Interfaces;

namespace Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution.Base
{
   public abstract class MgCommonNonGenericSortedListBase<T> : SortedList, IMgCommonDictionaryBase<T>
   {
       public abstract List<T> GetAnagramSet(string anagramCandidate);


       public abstract List<T> GetPalindromSet();

       public abstract List<T> GetWildcardSet(string wildcard);


       //public virtual void Add(KeyValuePair<string, T> item)
       //{
       //    base.Add(item.Key, item.Value);
       //}
   }
}
