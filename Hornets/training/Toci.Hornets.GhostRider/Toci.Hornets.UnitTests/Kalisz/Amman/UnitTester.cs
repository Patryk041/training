using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Legnica.Amman.StringManipulator;
using Toci.Hornets.Legnica.Amman.StringManipulator.Workers;

namespace Toci.Hornets.UnitTests.Kalisz.Amman
{
    [TestClass]
    public class UnitTester
    {
        [TestMethod]
        public void StringceptionTest()
        {
            string[][] words =
            {
                new string[] {"Amman", "mm"}, 
                new string[]{"Amman", "Amm"}, 
                new string[]{"Amman", "amm"}, 
                new string[]{"Amman", "man"}, 
                new string[]{"Amman", "nam"},
                new string[]{"Amman", "b"}, 
                new string[]{"Amman", ""}, 
                new string[]{"", ""}, 
                new string[]{"Amman", "nammA"}, 
                new string[]{"Amman", "Aammn"}, 
                new string[]{"Amman", "aAnmn"}, 
                new string[]{"", "njvkdsb"},
                new string[]{"quid est veritas", "vir est quiadest"}, 
                new string[]{"salvador dali", "avida dollars"}, 
                new string[]{"julian tuwim", "lutni ujawmi"}, 

            };
            var stringceptions = new List<string[]>();
            var stringElements = new List<string[]>();
            var anagrams = new List<string[]>();

            foreach (var pair in words)
            {
                var unit = new AmmanStringCheck().RunStringOperations(pair[0], pair[1]);
                if (unit.IsAnagram) anagrams.Add(pair);
                if (unit.IsStringElementsInString) stringElements.Add(pair);
                if (unit.IsStringInString) stringceptions.Add(pair);
            }
        }

        
    }
}