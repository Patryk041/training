using System.Collections.Generic;
using System.Linq;
using Anathema.stpetersburgstakeout.linq;

namespace Anathema.Lurppis.TestDoLinQOperations
{
    public class Tescik : LinqOperations
    {
         public List<string> GetProffesionList(string key)
         {
             return ListaSlownikowa.Where(item => item.Key == key).Select(item => item.Value).ToList();
         }
    }
}