using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution.Interfaces;

namespace Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution.Base
{
    public abstract class MgCommonDictionaryBase<T> : Dictionary<string,T>, IMgCommonDictionaryBase<T>
    {
        public abstract List<T> GetAnagramSet(string anagramCandidate);

        public abstract List<T> GetPalindromSet();


        public abstract List<T> GetWildcardSet(string wildcard);

        
        public void Add(object key, object value)
        {
            base.Add(key.ToString(),(T)value);
        }
    }
}
