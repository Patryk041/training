using System.Collections.Generic;
using System.Linq;
using Anathema.stpetersburgstakeout.linq;

namespace Anathema.Shorcik.linq
{
    public class MoreLinqOperations : LinqOperations
    {
        public int GetDeveloperAmount(string value)
        {
            return ListaSlownikowa.Count(item => item.Value == value);
        }

        public bool GetDeveloperDictionaryWithFiveLetterKeyAmount()
        {
            return ListaSlownikowa.Where(item => item.Key.Length == 5).ToDictionary(item => item.Key, item=>item.Value) != null ? true : false;
        }
    }
}