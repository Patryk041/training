using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.String
{
    class StringManipulator:GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
         
           var subjectChar = subject.ToCharArray();
           var seekChar = seek.ToCharArray();

            Stringi information = new Stringi();

            return information.CharInWord(subjectChar, seekChar);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            
            SortrString word1= new SortrString();
            SortrString word2 = new SortrString();
            char[] subjectchar = word1.Sort(subject);
            char[] seekchar = word2.Sort(seek);
            Stringi information = new Stringi();

            int lenghtsubject = subject.Length;
            int lenghtseek = seek.Length;
            int sumcontrol = lenghtseek;

            for (int i = 0; i < lenghtsubject; i++)
            {
                for (int j = 0; j < lenghtseek; j++)
                {
                    if (subjectchar[i] == seekchar[j])
                    {
                        sumcontrol = sumcontrol - 1;
                        break;
                    }
                }
                if (sumcontrol == 0)
                {
                    return true;
                }
            }
            return false;

            

        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            int lenghtsubject = subject.Length;
            int lenghtseek = seek.Length;
            SortrString subjectChar = new SortrString();
            SortrString seekChar = new SortrString();
            return (subjectChar.Sort(subject) == seekChar.Sort(seek))&&(lenghtsubject == lenghtseek);
        }

        protected override string GetNick()
        {
            return "Pr0fes0r";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            throw new NotImplementedException();
        }
    }
}
