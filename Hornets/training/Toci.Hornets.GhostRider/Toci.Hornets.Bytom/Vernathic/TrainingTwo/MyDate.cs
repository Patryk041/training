using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Bytom.Vernathic.TrainingTwo
{
	internal class MyDate
	{
		public int Day { get; set; }
		public int Month { get; set; }
		public int Year { get; set; }

		public MyDate(string date)
		{
			int yearNumbers = int.Parse(date.Substring(0, 2));
			int monthNumbers = int.Parse(date.Substring(2, 2));
			Day = int.Parse(date.Substring(4, 2));

			GetCorrectYear(monthNumbers);
		}

		public MyDate(int year, int month, int day)
		{
			Day = day;
			Month = month;
			Year = year;
		}

		private class PeselMonth		//composition so much :D
		{
			private int _min;
			private int _max;

			public PeselMonth(int min, int max)
			{
				_min = min;
				_max = max;
			}
		}

		private Dictionary<PeselMonth, int> _peselMonthDictionary = new Dictionary<PeselMonth, int>()
		{
			{new PeselMonth( 1,12), 19 },
			{new PeselMonth(21,32), 20 },
			{new PeselMonth(41,52), 21 },
			{new PeselMonth(61,72), 22 },
			{new PeselMonth(81,92), 18 }
		};

		public bool IsDateValid()
		{
			//warunki kiedy data będzie poprawna:
			// dla miesięcy 1, 3, 5, 7, 8, 10, 12 - 31 dni
			// dla: 4, 6, 9, 11 - 30 dni
			// rok przestępny: 2 - 29 dni
			// rok normalny: 2 - 28 dni

			// todo: implement the method
			return isLeapYear(Year);
		}

		private bool isLeapYear(int year)
		{
			return false;
		}

		private bool GetCorrectYear(int monthNumbers)
		{

			//poszukać gdzie w słowniku jest liczba odpowiadająca monthNumbers
			return false;
		}

	}
}
