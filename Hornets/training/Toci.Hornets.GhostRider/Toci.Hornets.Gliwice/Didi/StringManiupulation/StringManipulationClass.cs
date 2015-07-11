
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Gliwice.Didi.StringManiupulation
{
   public class StringManipulationClass : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject != null && seek != null && subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (subject != null && seek != null)
            {
                List<char> letters = new List<char>(subject.ToCharArray());
                List<char> lettersSeek = new List<char>(seek.ToCharArray());
     
                letters.Sort();
                lettersSeek.Sort();

                return letters.ToString().Contains(lettersSeek.ToString());
            }
           return false; 
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
           return subject != null && seek != null && subject.ToCharArray().OrderBy(x => x).SequenceEqual(seek.ToCharArray().OrderBy(x => x));
        }

        protected override string GetNick()
        {
            return "Didi"; 
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
          return Run(subject, seek); 
        }
    }
}
