using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.Vernathic.TrainingTwo
{
	public class VnthPeselValidator : PeselValidator
	{
		private const int CorrectLenght = 11;

		private readonly List<int> _weights = new List<int>()
		{ 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

		protected override string CutOffDate(string pesel)
		{
			//returns only date characters from pesel string
			return pesel.Substring(0, 6);
		}

		private MyDate GetDateObject(string date)
		{
			var dateObj = MyDate.Date;

			dateObj.Year = int.Parse(date.Substring(0, 2));		//validate year
			dateObj.Month = int.Parse(date.Substring(2, 2));	//validate month
			dateObj.Day = int.Parse(date.Substring(4, 2));		//validate day

			return dateObj;
		}

		private bool IsDateValid(string date)
		{
			var dateObj = GetDateObject(date);

			return false;
		}

		protected override bool Checksum(string pesel)
		{
			if (HasCorrectLength(pesel))
			{
				List<int> peselNumbers = SplitToList(pesel);
				if (ChecksumAreEqual(CalculateChecksum(peselNumbers), GetChecksum(peselNumbers)))
				{
					return true;
				}
				//compare with last number
			}
			return false;
		}

		private bool ChecksumAreEqual(int calculatedChecksum, int checksumCandidate)
		{
			return calculatedChecksum == checksumCandidate;
		}

		private int GetChecksum(List<int> peselNumbers)
		{
			return peselNumbers[peselNumbers.Count - 1];
		}

		private int CalculateChecksum(List<int> peselNumbers)
		{
			return _weights.Select((t, i) => peselNumbers[i] * t).Sum();

			//for (int i = 0; i < weights.Count; i++)
			//{
			//	checkSum += peselNumbers[i]*weights[i];
			//}
		}

		private List<int> SplitToList(string pesel)
		{
			return pesel.Select(ch => int.Parse(ch.ToString())).ToList();
			
			//var result = new List<int>();

			//foreach (var ch in pesel)
			//{
			//	int i = int.Parse(ch.ToString());
			//	result.Add(i);
			//}

			//return result;
		}

		protected override bool ValidateDate(int year, int month, int day)
		{
			throw new NotImplementedException();
		}

		private bool HasCorrectLength(string pesel)
		{
			return CorrectLenght == pesel.Length;
		}

		public override string GetNick()
		{
			return "Vernathic";
		}

		public override bool IsPeselValid(string pesel)
		{
			if()
		}
	}

	class MyDate
	{

		public int Day;
		public int Month;
		public int Year;

		private static MyDate _date;

		private MyDate() {}

		public static MyDate Date
		{
			get
			{
				return _date ?? (_date = new MyDate());
				//if (date == null)
				//{
				//	date = new MyDate();
				//}
				//return date;
			}
		}
	}
}
