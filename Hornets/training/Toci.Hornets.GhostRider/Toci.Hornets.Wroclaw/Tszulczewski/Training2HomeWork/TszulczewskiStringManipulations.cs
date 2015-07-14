using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Wroclaw.Tszulczewski.Training2HomeWork
{
    public class TszulczewskiStringManipulations : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            if (seek.Length > subject.Length)
                return false;
            if (seek.Equals(""))
                return true;
            
            for (int i = 0; i < subject.Length-seek.Length; i++)
            {
                if (subject.Substring(i, seek.Length).Equals(seek))
                    return true;
            }
            return false;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (seek.Length > subject.Length)
                return false;
            if (seek.Equals(""))
                return true;

            int sublength = seek.Length;
            char[] subjectChar = subject.ToCharArray();

            for (int k = 0; k < seek.Length; k++)
            {
                for (int i = 0; i < subject.Length - 1; i++)
                {
                    if (seek[k] == subjectChar[i])
                    {
                        subjectChar[i] = ' ';
                        sublength--;
                    }
                    if (sublength == 0)
                        return true;
                }
            }
                return false;
            //throw new System.NotImplementedException();
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            if (seek.Length != subject.Length)
                return false;
            if (seek == subject)
                return true;
            return IsStringElementsInString(subject, seek);
        }

        protected override string GetNick()
        {
            return "Tszulczewski";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Seek = seek;
            result.Subject = subject;

            result.Type = GetType();

            result.IsStringInString = IsStringInString(subject, seek);
            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            result.IsStringElementsInString = IsStringElementsInString(subject, seek);

            return result;

        }
    }
}