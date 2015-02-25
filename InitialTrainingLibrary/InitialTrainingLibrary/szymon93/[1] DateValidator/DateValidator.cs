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
		//Constructors
		public DateValidator()
		{ }

		//Methods
		public bool DateValidate(int year, int month, int day)
		{
			DaysChecker daysChecker = new DaysChecker(day);
			MonthsChecker monthsChecker = new MonthsChecker(month);
			YearsChecker yearsChecker = new YearsChecker(year);	

			return ReturnResult(CheckDateGenerally(daysChecker.CheckDay(), monthsChecker.ChceckMonth(), yearsChecker.ChceckYear()),
				day,month,year);
		}

		private bool CheckDateGenerally(bool day, bool month, bool year)
		{
			return day && month && year;
		}


		public string GetName()
		{
			return "Szymon";
		}

		private bool ReturnResult(bool IsGenerallyDateCorrect, int day, int month, int year)
		{
			bool Result = false;

			if(IsGenerallyDateCorrect)
			{
				//Check the date depends on the particular day
				SpecificDate specificDate = new SpecificDate(day, month, year);
				Result = specificDate.CheckDateSpecific();
			}

			return Result;
		}
	}
}
