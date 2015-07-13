using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntStringManipulations
{
    public class S2yfr4ntStringManipulations: GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Equals(seek) || subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            var _subject = subject.ToList();
            foreach (var character in seek)
            {
                if (!_subject.Contains(character)) return false;
                _subject.Remove(character);
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return subject.OrderBy(c => c).SequenceEqual(seek.OrderBy(c => c));
        }

        protected override string GetNick()
        {
            return "S2yfr4nt";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            return Run(subject, seek);
        }
        protected override StringManipulationsResults Run(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;
            result.Type = GetType();

            S2yfr4ntFacade facade = new S2yfr4ntFacade(result);

            if (!IsStringElementsInString(subject, seek))
            { 
                facade.AllFalse();
            }
            else if (!IsStringInString(subject, seek))
            {
                facade.OneTrue();
            }
            else if (!IsStringAnagramOfString(subject, seek))
            {
                facade.TwoTrue();
            }
            else
            {
                facade.AllTrue();
            }
            
            return result;
        }
    }
}