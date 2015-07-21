
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.gipson.Homework0407
{
    public class GipsonStringManipulations : GhostRiderStringManipulationsBase
    {
        // true: beata; at, ata, ta, ea
        // false: beata; ae, eb, aa
        protected override bool IsStringInString(string subject, string seek)
        {
            if (seek.Length > subject.Length)
                return false;
            if (seek.Equals(""))
                return true;

            for (int i = 0; i <= subject.Length - seek.Length; i++)
            {
                if (subject.Substring(i, seek.Length).Equals(seek))
                    return true;
            }
            return false;

            //throw new NotImplementedException();
        }

        // true: beata; aat, taae, aea
        // false: beata; aaa, taaa, tta, aee
        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (seek.Length > subject.Length)
                return false;
            if (seek.Equals(""))
                return true;

            string subjectCopy = subject;
            //string seekCopy = seek;
            for (int i = 0; i < seek.Length; i++)
            {
                int j = 0;
                while (j < subjectCopy.Length)
                {
                    if (seek[i].Equals(subjectCopy[j]))
                    {
                        if (j == 0)
                            subjectCopy = subjectCopy.Substring(1);
                        else
                        {
                            subjectCopy = subjectCopy.Substring(0, j) + subjectCopy.Substring(j + 1);
                        }
                        j = subjectCopy.Length + 2;
                    }
                    else if (j == subjectCopy.Length - 1)
                    {
                        return false;
                    }
                    j++;
                }
            }

            return true;
            //throw new NotImplementedException();
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (seek.Length != subject.Length)
                return false;
            return IsStringElementsInString(subject, seek);

            //throw new NotImplementedException();
        }

        protected override string GetNick()
        {
            return "gipson";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();

            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            result.IsStringInString = IsStringInString(subject, seek);

            return result;
        }
    }
}
