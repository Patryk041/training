using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.szymon93._1__DateValidator
{
	class MonthsChecker
	{
		//Fields
		int month;

		//Contructors
		public MonthsChecker(int month)
		{
			this.month = month;
		}
		
		//Methods
		public bool ChceckMonth()
		{
			if(month>0 && month<13)
				return true;
			else
				return false;
		}
	}
}
