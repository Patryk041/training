using System;
using System.Diagnostics;
using System.Linq;

namespace Toci.TraininigLibrary.Developers.Chmura.Common
{
    public static class ChmuraTrainingThreeExtensions
    {
        public static void ChmuraWriteErrorToLog(this string s)
        {
            string cs = "QualityDocHandler";
            EventLog elog = new EventLog();
            if (!EventLog.SourceExists(cs))
                EventLog.CreateEventSource(cs, "Application");
            elog.Source = cs;
            elog.EnableRaisingEvents = true;
            EventLog.WriteEntry(cs, s, EventLogEntryType.Error);
        }
        public static bool ChmuraIsPalindrom(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            
            return new string(charArray) == s;
        }

        public static bool ChmuraIsAnagram(this string s, string anagramCandidate)
        {
            if (s.Length != anagramCandidate.Length)
            {
                return false;
            }
            foreach (char x in s)
            {
                if (anagramCandidate.Contains(x))
                {
                    anagramCandidate.Remove(anagramCandidate.IndexOf(x));
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ChmuraIsWildcard(this string s, string wildcardCandidate)
        {
            if (wildcardCandidate.Length<s.Length)
            {
                s = s.Remove(wildcardCandidate.Length);
            }
            return s == wildcardCandidate;
        }
    }
}
