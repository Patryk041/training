using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.szymon93._1__DateValidator
{
	class DaysChecker
	{
		//Fields
		int day;
		
		//Constructor
		public DaysChecker(int day)
		{
			this.day = day;
		}

		//Methods
		public bool CheckDay()
		{
			if(day>0 && day<32)
				return true;
			else
				return false;
		}
	}
}
