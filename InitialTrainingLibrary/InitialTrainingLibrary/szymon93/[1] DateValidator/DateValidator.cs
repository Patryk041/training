using InitialTrainingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.szymon93._1__DateValidator
{
	class DateValidator : IDateValidator
	{
		//Fields
		YearsChecker yearsChecker;
		MonthsChecker monthsChecker;
		DaysChecker daysChecker;

		//Constructors
		public DateValidator()
		{ }

		//Methods
		public bool DateValidate(int year, int month, int day)
		{


			return false;
		}

<<<<<<< HEAD
		public string GetName()
=======
		public  string GetName()
>>>>>>> 66fc688fea23caaa3a1b4f7d68f8041dae8da0aa
		{
			return "Szymon";
		}
	}
}
