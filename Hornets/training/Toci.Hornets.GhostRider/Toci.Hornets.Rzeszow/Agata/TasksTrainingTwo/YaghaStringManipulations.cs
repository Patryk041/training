using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Agata.TasksTrainingTwo
{
    public class YaghaStringManipulations : GhostRiderStringManipulationsBase
    {
        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }

        protected override bool IsStringInString(string subject, string seek)
        {
            IsNullOrEmptyCheck(subject, seek);
            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            IsNullOrEmptyCheck(subject, seek);
            var checkedChars = new List<char>();
            for (int i = 0; i < seek.Length; i++)
            {
                if (checkedChars.Contains(seek[i])) continue;
                var charsCountSubject = subject.Count(x => x.ToString().Contains(seek[i]));
                var charsCountSeek = seek.Count(x => x.ToString().Contains(seek[i]));
                if (charsCountSubject != charsCountSeek) return false;
                checkedChars.Add(seek[i]);
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            IsNullOrEmptyCheck(subject, seek);
            if(subject.Length == seek.Length)
            {
                return IsStringElementsInString(subject, seek);
            }
            return false;
        }

        protected override string GetNick()
        {
            return "yagha";
        }

        private void IsNullOrEmptyCheck(string subject, string seek)
        {
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(seek))
                throw new Exception("subject lub seek są nullem");
        }
            
       
    }
}