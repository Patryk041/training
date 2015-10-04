using System.Collections.Generic;
using System.Linq;

namespace Anathema.Igor.LinqOperations
{
    public class LinqOperationExtended : stpetersburgstakeout.linq.LinqOperations
    {
        public List<string> GetArchitectList()
        {
            return ListaSlownikowa.Where(item => item.Value == "Architect").Select(item => item.Key).ToList();
        }
    }
}
