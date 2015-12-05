using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Rhonin.Words
{
    /// <summary>
    /// Filter sets Class
    /// Version 0.1
    /// </summary>
    public class FilterSets
    {
        public string[] words { get; set; }

        /// <summary>
        /// Check the words it is an palindrom.
        /// </summary>
        /// <param name="palindromCandidateList"></param>
        /// <returns>true/false</returns>
        public string[] GetPalindroms(string[] palindromCandidateList)
        {
            foreach (var palindrom in palindromCandidateList)
            {
                if(!TextUtils.IsPalindrom(palindrom))
                {
                    palindromCandidateList = palindromCandidateList.Where(value => value != palindrom).ToArray();
                }

            }
            return palindromCandidateList;
        }

        /// <summary>
        /// Check the words are anagrams.
        /// </summary>
        /// <param name="anagrams"></param>
        /// <returns></returns>
        public string[] GetAnagramsSet(string anagram)
        {
            foreach(var value in words)
            {
                if (!TextUtils.IsAnagram(anagram,value))
                {
                    words = words.Where(val => val != value).ToArray();
                }

            }
            return words;
        }

        /// <summary>
        /// Check the words that are start with string given.
        /// </summary>
        /// <param name="wildcard"></param>
        /// <returns></returns>
        public string[] GetWildCards(string wildcard)
        {
            foreach (var value in words)
            {
                if (!TextUtils.IsWildCard(value,wildcard))
                {
                    words = words.Where(val => val != value).ToArray();
                }
            }
            return words;
        }
    }
}
