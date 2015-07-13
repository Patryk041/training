using System;
using System.Collections.Generic;
using System.Globalization;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Rzeszow.Sherpin.TasksTrainingTwo
{
    public class SherStringManipulations : GhostRiderStringManipulationsBase
    {
        // Metoda sprawdzająca czy podane stringi nie są puste lub nie są nullem.
        public void NullEmptyTest(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                throw new Exception("One or both of the following strings are null or empty");
            }
        }

        // Zlicza wystepowanie danych znaków w stringach
        public void countingChars(int[] tab1, int[] tab2, string s1, string s2)
        {
            for (int i = 0; i < 256; i++)
            {
                tab1[i] = 0;
                tab2[i] = 0;
            }
            for (int i = 0; i < s1.Length; i++)
            {
                tab1[s1[i]]++;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                tab2[s2[i]]++;
            }
        }
        protected override bool IsStringInString(string subject, string seek)
        {
            NullEmptyTest(subject, seek);

            return subject.Contains(seek);
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            NullEmptyTest(subject, seek);

            int[] tabSubject = new int[256];
            int[] tabSeek = new int[256];
            countingChars(tabSubject, tabSeek, subject, seek);

            for (int i = 0; i < 256; i++)
            {
                if (tabSubject[i] - tabSeek[i] < 0) return false;
            }
            return true;
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            int[] tabSubject = new int[256];
            int[] tabSeek = new int[256];
            countingChars(tabSubject, tabSeek, subject, seek);

            for (int i = 0; i < 256; i++)
            {
                if (tabSubject[i] - tabSeek[i] != 0) return false;
            }
            return true;
        }

        protected override string GetNick()
        {
            return "Sherpin";
        }

        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();

            if (IsStringAnagramOfString(subject, seek))
            {
                result.IsAnagram = true;
                result.IsStringElementsInString = true;
                result.IsStringInString = true;
            }
            else if (IsStringInString(subject, seek))
            {
                result.IsAnagram = false;
                result.IsStringElementsInString = true;
                result.IsStringInString = true;

            }
            else if (IsStringElementsInString(subject, seek))
            {
                result.IsAnagram = false;
                result.IsStringElementsInString = true;
                result.IsStringInString = false;
            }
            else
            {
                result.IsAnagram = false;
                result.IsStringElementsInString = false;
                result.IsStringInString = false;
            }

            return result;
        }       
    }
}