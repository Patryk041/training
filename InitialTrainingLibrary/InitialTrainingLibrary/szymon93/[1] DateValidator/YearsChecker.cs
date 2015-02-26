using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.szymon93._1__DateValidator
{
	class YearsChecker
	{
		//Fields
		int year;

		//Constructors
		public YearsChecker(int year)
		{
			this.year = year;
		}

		//Methods
		public bool ChceckYear()
		{
			if(year>=0)
				return true;
			else
				return false;
		}
	}
}
