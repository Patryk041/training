using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Gliwice.Didi.StringManiupulation
{
   public class StringManipulationClass : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            List<char> letters = new List<char>(subject.ToCharArray());
            List<char> lettersSeek = new List<char>(seek.ToCharArray());
            List<int> temp= new List<int>();
            int k = 0; 

            for (int i = 0; i < letters.Count(); i++)
            {
                for (int j = 0; j < lettersSeek.Count(); j++)
                {
                    if (letters[i] == lettersSeek[j])
                    {
                        if (!temp.Contains(j))
                        {
                            temp.Add(j);

                            if (temp.Count() > 1 && temp[k - 1] + 1 != temp[k])
                            {
                                return false;
                            }
                            k++;
                        }
                        break; 
                    }
                } 
            }
            return true; 
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            List<char> letters = new List<char>(subject.ToCharArray());
            List<char> lettersSeek = new List<char>(seek.ToCharArray());
            List<int> temp = new List<int>();

            letters.Sort();
            lettersSeek.Sort();

            for (int i = 0; i < letters.Count(); i++)
            {
                for (int j=0; j < lettersSeek.Count(); j++)
                {
                    if (letters[i] == lettersSeek[j])
                    {
                        if (!temp.Contains(j))
                        {
                            temp.Add(j);
                        }   
                        break; 
                    }
                }
            }
            return temp.Count() == lettersSeek.Count(); 
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            List<char> letters = new List<char>(subject.ToCharArray());
            List<char> lettersSeek = new List<char>(seek.ToCharArray());
           
            letters.Sort();
            lettersSeek.Sort();

           // return Equals(letters.ToString(), lettersSeek.ToString());

            for (int i = 0; i < letters.Count(); i++)
            {
                for (; i < lettersSeek.Count(); )
                {
                    if (letters[i] != lettersSeek[i])
                    {
                        return false;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return true; 
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
