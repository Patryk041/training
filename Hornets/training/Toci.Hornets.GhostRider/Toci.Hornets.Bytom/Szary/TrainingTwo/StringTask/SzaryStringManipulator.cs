using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Bytom.Szary.TrainingTwo.StringTask
{
    public class SzaryStringManipulator:GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            var subjectChar = subject.ToCharArray();
            var seekChar = seek.ToCharArray();

            var information = new Stringi();

            return information.CharInWord(subjectChar, seekChar);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            var word1 = new SortString();
            var word2 = new SortString();
            var subjectchar = word1.Sort(subject);
            var seekchar = word2.Sort(seek);
            var information = new Stringi();

            var lenghtsubject = subject.Length;
            var lenghtseek = seek.Length;
            var sumcontrol = lenghtseek;

            for (var i = 0; i < lenghtsubject; i++)
            {
                for (var j = 0; j < lenghtseek; j++)
                {
                    if (subjectchar[i] != seekchar[j]) continue;
                    sumcontrol = sumcontrol - 1;
                    break;
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
            var lenghtsubject = subject.Length;
            var lenghtseek = seek.Length;
            var subjectChar = new SortString();
            var seekChar = new SortString();
            return (subjectChar.Sort(subject) == seekChar.Sort(seek)) && (lenghtsubject == lenghtseek);
        }

        protected override string GetNick()
        {
            return "Szary";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            throw new System.NotImplementedException();
        }
    }
}