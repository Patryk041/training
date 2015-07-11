using System;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.SemiRafista.TrainingTwoStringManipulations
{
    public class SeRaManipulatingStrings : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            var returnValue = false;
            var temporarySubject = subject;
            for(var i=0; i<seek.Length; i++)
            {
                if (temporarySubject.Contains(seek.ElementAt(i).ToString()))
                {
                    returnValue = true;
                    var indexOfElement = temporarySubject.IndexOf(seek.ElementAt(i));
                    temporarySubject = temporarySubject.Remove(indexOfElement, 1);
                }
                else
                {
                    returnValue = false;
                    break;
                }
            }
            return returnValue;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return (SortString(subject) == SortString(seek));
        }

        protected string SortString(string word)
        {
            var temp = word.ToCharArray();
            Array.Sort(temp);
            return new string(temp);
        }

        protected override string GetNick()
        {
            return "SemiRafista";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            StringManipulationsResults result = new StringManipulationsResults();

            result.Subject = subject;
            result.Seek = seek;
            result.Nick = GetNick();
            result.Type = GetType();
            
            if (IsStringAnagramOfString(subject,seek))
            {
                result.IsAnagram = true;
                result.IsStringElementsInString = true;
                result.IsStringInString = true;
            }
            else
            {
                result.IsAnagram = false;
                if (IsStringInString(subject, seek))
                {
                    result.IsStringInString = true;
                    result.IsStringElementsInString = true;
                }
                else
                {
                    result.IsStringInString = false;
                    result.IsStringElementsInString = IsStringElementsInString(subject, seek);
                }
            }

            return result;
        }
    }
}