using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

namespace Toci.Hornets.Bytom.Vernathic.Generics
{
	class VnthGenericList<T> : GhostRiderGenericList<T>
	{
		private int index = 0;
		private T[] content;
		
		public override bool Add(T item)
		{
			if (index >= 0)
			{
				content[index] = item;
				index++;
				return true;
			}
			return false;
		}

		public override bool Remove(T item)
		{
			//sprawdź w liście
			if (index > 0)
			{
				return true;
			}
			return false;
		}
	}
}
