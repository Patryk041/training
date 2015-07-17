using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;


namespace Toci.Hornets.Bytom.InkNinja.TrainingTwo.StringTask
{
    class InkString : GhostRiderStringManipulationsBase
    {
        //powinno banglać
        protected override bool IsStringInString(string subject, string seek)
        {
            bool value = false;
            for (int i = 0; i + seek.Length < subject.Length; i++)
            {
                int j;
                for (j = 0; j < seek.Length; j++)
                    if (subject[i + j] == seek[j])
                        continue;
                    else
                        break;
                if (j == seek.Length)
                {
                    value = true;
                    break;
                }
            }
            return value;
        }

        protected override bool IsStringElementsInString(string subject, string seek) {
            bool value = true;
            bool  [] t= new bool [subject.Length];
            for (int i = 0; i < t.Length; i++)
                t[i] = false;
            int j;
            for (int i = 0; i < seek.Length; i++)
            {
                for (j = 0; j < subject.Length; j++)
                    if (subject[j] == seek[i] && t[j] )
                    {
                        t[j] = false;
                        break;
                    }
                    else
                        continue;
                if (j == subject.Length)
                {
                    value = false;
                    break;
                }
            }
            return value;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek) 
        {
            if (subject.Length != seek.Length)
                return false;
            return IsStringElementsInString(subject, seek);
        }

        protected override string GetNick()
        {
            return "InkNinja";
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

            result.Type = this.GetType();

            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            result.IsStringInString = IsStringInString(subject, seek);

            if (!result.IsStringElementsInString)
                result.IsAnagram = false;
            else
                result.IsAnagram = (subject.Length == seek.Length);

            return result;
        }

    }
}
