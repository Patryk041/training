using System;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Legnica.Patryk_Stulczewski.Utils;

namespace Toci.Hornets.Legnica.Michał_Zembik
{
    public class ZadanieStringManipulations : GhostRiderStringManipulationsBase
    {
        // true: beata; at, ata, ta, ea
        // false: beata; ae, eb, aa
        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }

        // true: beata; aat, taae, aea
        // false: beata; aaa, taaa, tta, aee
        protected override bool IsStringElementsInString(string subject, string seek)
        {
            char[] which = new char[subject.Length]; //tu beda przechowywane literki do kasacji
           
            if (seek.Length > subject.Length) 
                return false;

            if (seek.Length == subject.Length)
            {


                if (IsStringAnagramOfString(subject, seek))
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            //w tych petelkach beda wychwytywane literki ktore nie pasuja
            int d = 0;
            for (int i = 0; i < subject.Length; i++)
                for (int j = 0; j < seek.Length; j++)
                {
                    if (subject[i]==seek[j])
                    {
                        break;
                    }
                    if (j == seek.Length-1)
                    {
                        
                        which[d] = subject[i];
                        d++;
                    }
                        
                }
            var v2 = seek.ToArray();
            var v1 = subject.ToArray();
            for (int i=0;i<d;i++)
            {
                
                v1 = v1.Where(val => val != which[i]).ToArray(); //kasujemy literki

            }
            Array.Sort(v1);
            Array.Sort(v2);

            subject = new string(v1);
            seek = new string(v2);
    
            if (subject.Contains(seek))

            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

     
        // true: beata; ataeb, aateb, tbaea
        // false: beata; aaateb, fdwgdw
        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            return subject.Length == seek.Length && AreEqual(subject, seek);
        }


        private bool AreEqual(string subject, string seek)
        {
           var v = subject.ToArray();
           var v1 = seek.ToArray();
           Array.Sort(v);
           Array.Sort(v1);
           return v.SequenceEqual(v1);
        }

        protected override string GetNick()
        {
            return "Michal Zembik";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
              return Run(subject, seek);
        }
    }
}