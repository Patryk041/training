using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Bytom.Common.DrHouse.Logic
{
	public abstract class DbHandle
	{
		// todo: work on it
		public abstract bool Insert();
		public abstract bool Delete();
		public abstract bool Fetch();

		//http://www.codeproject.com/Articles/4416/Beginners-guide-to-accessing-SQL-Server-through-C
	}
}
