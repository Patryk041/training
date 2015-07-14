using System;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
/*Dosc toporna wersja. Spore problemy z internetem spowodowaly, ze z komend za bardzo korzystac nie moglem
 a telefon slabo dawal rade. Stad kod raczej prymitywny*/

namespace Toci.Hornets.Gliwice.usppat.TasksTrainingTwo.StringManipulations
{
    public class StringManipulatorVerUsppat : GhostRiderStringManipulationsBase
    {
        protected override bool IsStringInString(string subject, string seek)
        {
            int sprawdzana=0;
            if (subject.Length < seek.Length)
            {
                return false;
            }
            for (int i = 0; i < subject.Length; i++)
            {
                if (subject[i] == seek[0])
                {
                    for (int j=0; j < seek.Length; j++)
                    {
                        if (subject[i + j] == seek[j])
                        {
                            sprawdzana++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (sprawdzana == seek.Length)
                    {
                        return true;
                    }
                    else
                    {
                        sprawdzana = 0;
                    }
                }
            }
            return false;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            if (subject.Length < seek.Length)
            {
                return false;
            }
            int sprawdzana = 0;
            string[] SortSubject = new string[subject.Length];
            string[] SortSeek = new string[seek.Length];
            for (int i = 0; i < subject.Length; i++)
            {
                SortSubject[i] = subject[i].ToString();
            }
            for (int i = 0; i < seek.Length; i++)
            {
                SortSeek[i] = seek[i].ToString();
            }
            Array.Sort(SortSeek);
            Array.Sort(SortSubject);
            for (int i = 0; i < subject.Length; i++)
            {
                if (subject[i] == seek[0])
                {
                    for (int j = 0; j < seek.Length; j++)
                    {
                        if (subject[i + j] == seek[j])
                        {
                            sprawdzana++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (sprawdzana == seek.Length)
                    {
                        return true;
                    }
                    else
                    {
                        sprawdzana = 0;
                    }
                }
            }
            return false;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {

            if (subject.Length != seek.Length)
            {
                return false;
            }
           string[] SortSubject = new string[subject.Length];
           string[] SortSeek = new string[seek.Length];
           for (int i = 0; i < subject.Length; i++)
           {
               SortSubject[i] = subject[i].ToString();
               SortSeek[i] = seek[i].ToString();
           }
           Array.Sort(SortSeek);
           Array.Sort(SortSubject);
           for (int i = 0; i < subject.Length; i++)
           {
               if (SortSubject[i] == SortSeek[i])
               {
                   return false;
               }
           }
            return true;
        }

        protected override string GetNick()
        {
            return "usppat";
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

            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            result.IsStringInString = IsStringInString(subject, seek);

            return result;
        }
    }
}