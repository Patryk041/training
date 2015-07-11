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
          
            for(var i = 0;i<seek.Length;i++)
            {
                for (var j = 0; j < subject.Length; j++)
                {
                    if (seek[i] != subject[j]) continue;
                    subject = subject.Remove(j, 1);
                    seek = seek.Remove(i, 1);
                    i = -1;
                    break;
                }

            }
            return seek == "";
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            var _subject    = DuchStringUtills.OrderString(subject);
            var _seek       = DuchStringUtills.OrderString(seek);

            return _seek.SequenceEqual(_subject);
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
