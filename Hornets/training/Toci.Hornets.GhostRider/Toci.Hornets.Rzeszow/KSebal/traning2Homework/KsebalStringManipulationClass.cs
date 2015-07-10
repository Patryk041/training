using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.KSebal.traning2Homework
{
    public class KsebalStringManipulationClass:GhostRiderStringManipulationsBase
    {

        public string SortFunction(string subject)
        {
            return string.Concat(subject.ToLower().OrderBy(item => item));
        }

        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.ToLower().Contains(seek.ToLower());
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            string helper = subject.ToLower();
            string seekhelper = seek.ToLower();
            for(int i=0;i<seekhelper.Length;i++)
            {
                if (helper.Contains(seekhelper[i])) helper=helper.Remove(helper.IndexOf(seekhelper[i]),1);
                else return false;
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return SortFunction(subject) == SortFunction(seek) &&
                   subject.Length == seek.Length;
        }
            



        protected override string GetNick()
        {
            return "Ksebal";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
           return Run(subject, seek);
        }
    }
}
