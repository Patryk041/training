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
		int day, month, year;
		List<int[]> Months = new List<int[]>();
		
		//Constructors
		public DaysChecker(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;

			EnterDataAboutDaysInMonths(year);
		}

		//Methods
		void EnterDataAboutDaysInMonths(int Year)
		{
			Months.Clear();

			Months.Add(new int[31]); //January
			if(IsLeapYear(Year)) //February
				Months.Add(new int[29]);
			else
				Months.Add(new int[28]);
			Months.Add(new int[31]); //March
			Months.Add(new int[30]); //April
			Months.Add(new int[31]); //May
			Months.Add(new int[30]); //June
			Months.Add(new int[31]); //July
			Months.Add(new int[31]); //August
			Months.Add(new int[30]); //September
			Months.Add(new int[31]); //October
			Months.Add(new int[30]); //November
			Months.Add(new int[31]); //December
		}

		bool IsLeapYear(int year)
		{
			return ((year%4 == 0 && year%100 != 0) || year%400 == 0);
		}
		
		public bool CheckDayGenerally(int day)
		{
			if(day>0 && day<32)
				return true;
			else
				return false;
		}
	}
}
