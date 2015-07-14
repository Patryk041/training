using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.Vernathic.TrainingTwo
{
	public class VnthPeselValidator : PeselValidator
	{
		private const int CorrectLenght = 11;

		private readonly List<int> _weights = new List<int>() { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

		protected override string CutOffDate(string pesel)
		{
			//returns only date characters from pesel string
			return pesel.Substring(0, 6);
		}

		private MyDate GetDateObject(string date)
		{
			var dateObj = MyDate.Date;

			dateObj.Year = int.Parse(date.Substring(0, 2));		// todo: validate year
			dateObj.Month = int.Parse(date.Substring(2, 2));	// todo: validate month
			dateObj.Day = int.Parse(date.Substring(4, 2));		// todo: validate day

			return dateObj;
		}

		private bool IsDateValid(string date)
		{
			// todo: fix this
			var dateObj = GetDateObject(date);

			return false;
		}

		protected override bool Checksum(string pesel)
		{
			if (HasCorrectLength(pesel))
			{
				return CurrentChecksumEqualsCalculatedChecksum(pesel);
			}
			return false;
		}

		private bool CurrentChecksumEqualsCalculatedChecksum(string pesel)
		{
			List<int> peselNumbers = SplitToList(pesel);
			int currentChecksum = GetChecksum(peselNumbers);
			int calculatedChecksum = CalculateChecksum(peselNumbers);

			if (currentChecksum == calculatedChecksum)
			{
				return true;
			}
			return false;
		}

		private int GetChecksum(List<int> peselNumbers)
		{
			return peselNumbers[peselNumbers.Count - 1];
		}

		private int CalculateChecksum(List<int> peselNumbers)
		{
			return (10 - ((_weights.Select((t, i) => peselNumbers[i] * t).Sum()) % 10)) % 10;

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
			return false;
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
			return Checksum(pesel);
		}
	}

	
}
