using System;
using System.Collections.Generic;
using Toci.Hornets.Kalisz.Amman.StringManipulator.Workers;

namespace Toci.Hornets.Kalisz.Amman.StringManipulator
{
    public class BatchAnagram
    {
        public static List<string[]> Go(string tekst)
        {
            var listaAnagramow = new List<string[]>();
            tekst = tekst.ToLowerInvariant();
            var baza = tekst.Split(' ');
            foreach (string t1 in baza)
            {
                if (t1.Length < 3) continue;
                foreach (string t in baza)
                {
                    if (t.Length < 3) continue;
                    if (t1.Equals(t)) continue;
                    if (!Anagram.IsAnagram(t1, t)) continue;
                    var result = new string[2];
                    result[0] = t1;
                    result[1] = t;
                    listaAnagramow.Add(result);
                }
            }
            return listaAnagramow;
        }
    }
}