using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Terry.TrainingTwo.StringManipulation
{
    public class TerryStringManipulator : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            var seekArr = seek.ToCharArray();
            var subArr = subject.ToCharArray();
  
            var seekInSubList = new List<char[]>();
            var seekList = new List<char[]>();

            for (int i = 0; i < seekArr.Length; i++)
            {
                 seekInSubList.Add(Array.FindAll(subArr, c => c == seekArr[i]));
                 seekList.Add(Array.FindAll(seekArr, c => c == seekArr[i]));
            }
            
            var seekResult = TrimListsOfCharArrays(seekList);
            var subResult = TrimListsOfCharArrays(seekInSubList);

            Array.Sort(seekResult);
            Array.Sort(subResult);
          
            return subResult.SequenceEqual(seekResult);

        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            var seekArr = seek.ToCharArray();
            var subArr = subject.ToCharArray();

            Array.Sort(subArr);
            Array.Sort(seekArr);

            return seekArr.SequenceEqual(subArr);
        }

        protected override string GetNick()
        {
            return "Terry";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }

        protected char[] TrimListsOfCharArrays(List<char[]> list)
        {
            list.RemoveAll(c => c.Length == 0);
            var listToArr = list.ToArray();
            var result = new char[listToArr.Length];

            for (int i = 0; i < listToArr.Length; i++)
            {
                result[i] = listToArr[i].First();
            }

            return result;
        }
    }
}