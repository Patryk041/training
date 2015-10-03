using System.Collections.Generic;
using System.Linq;
using Anathema.stpetersburgstakeout.linq;

namespace Anathema.Sancho.Linq
{
	public class SuperLinq : LinqOperations
	{
		public List<string> GetUsernamesByValue(string value)
		{
			return ListaSlownikowa.Where(item => item.Value == value).Select(item => item.Key).ToList();
		}
	}
}