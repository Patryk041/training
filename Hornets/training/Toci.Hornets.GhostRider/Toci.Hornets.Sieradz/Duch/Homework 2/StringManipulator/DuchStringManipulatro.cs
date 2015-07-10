using System;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.Duch.Homework_2.StringManipulator
{
    public class DuchStringManipulatro : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.ToLower().Contains(seek.ToLower());
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            var _subject = subject.ToLower().ToArray();
            var _seek = subject.ToLower().ToArray();
            Array.Sort(_seek);
            Array.Sort(_subject);
            return _subject.Intersect(_seek).Any();
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            var _subject = subject.ToLower().ToArray();
            var _seek = subject.ToLower().ToArray();
            Array.Sort(_seek);
            Array.Sort(_subject);
            return  _seek == _subject;
        }

        protected override string GetNick()
        {
            return "Duch";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults
            {
                Subject = subject,
                Seek = seek,
                Type = this.GetType(),
                Nick = GetNick()
            };


            if (IsStringAnagramOfString(subject, seek))
            {
                result.IsAnagram = true;
                result.IsStringElementsInString = true;
                result.IsStringInString = true;
            }
            else if (IsStringInString(subject, seek))
            {
                result.IsAnagram = false;
                result.IsStringElementsInString = true;
                result.IsStringInString = true;  
            }
            else if (IsStringElementsInString(subject, seek))
            {
                result.IsAnagram = false;
                result.IsStringElementsInString = true;
                result.IsStringInString = false;
            }
            else
            {
                result.IsAnagram = false;
                result.IsStringElementsInString = false;
                result.IsStringInString = false;
            }
            
            return result;
        }
    }
}
