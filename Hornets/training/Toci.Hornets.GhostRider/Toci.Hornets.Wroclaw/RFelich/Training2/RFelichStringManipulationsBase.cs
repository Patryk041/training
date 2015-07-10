using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Wroclaw.RFelich.Training2
{
 public abstract class RFelichStringManipulationsBase
    {
        // true: beata; at, ata, ta, ea
        // false: beata; ae, eb, aa
        protected abstract bool IsStringInString(string subject, string seek)
        {
	        if(subject.Contains(seek))
	        	{
	        	return true;
	        	}
        	else
        		return false;
        }


        // true: beata; aat, taae, aea
        // false: beata; aaa, taaa, tta, aee
        protected abstract bool IsStringElementsInString(string subject, string seek)
        {
            int compareIndex = 0;

            int[] compareSubjectArray = new int[128];
            int[] compareSeekArray = new int[128];

            for (int i = 0; i < 128; i++)
            {
                compareSeekArray[i] = 0;
                compareSubjectArray[i] = 0;
            }

            byte[] asciiSubject = Encoding.ASCII.GetBytes(subject);
            byte[] asciiSeek = Encoding.ASCII.GetBytes(seek);

            for (int i = 0; i < subject.Length; i++)
            {
                compareSubjectArray[asciiSubject[i]] += 1;
            }

            for (int i = 0; i < seek.Length; i++)
            {
                compareSeekArray[asciiSeek[i]] += 1;
            }

            for (int i = 0; i < 128; i++)
            {
                if (compareSeekArray[i] > compareSubjectArray[i])
                    compareIndex += 1;
            }

            if (compareIndex == 0)
                return true;
            else
                return false;

        }

        // true: beata; ataeb, aateb, tbaea
        // false: beata; aaateb, fdwgdw
        protected abstract bool IsStringAnagramOfString(string subject, string seek)
        {
	        char[] word1 = subject.ToCharArray();
        	Array.Sort(word1);
        	string newSubject = new string(word1);

        	char[] word2 = seek.ToCharArray();
        	Array.Sort(word2);
        	string newSeek = new string(word2);

            if (newSubject.CompareTo(newSeek) == 0)
            {
                return true;
            }
            else
                return false;
	
        }

        protected abstract string GetNick()
        {
            return "RFelich";
        }

        public abstract StringManipulationsResults RunStringOperations(string subject, string seek);

        protected virtual StringManipulationsResults Run(string subject, string seek)
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
